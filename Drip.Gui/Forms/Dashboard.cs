using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Drip.Gui.Api;
using Drip.Gui.Controls;
using Drip.Gui.CustomLogic;
using Drip.Gui.Processing;
using Drip.Gui.Utility;
using Illinois.SeaPerch.Net;
using Ozeki.Media;
using utils;
using XInputDotNetPure;

namespace Drip.Gui.Forms
{
    public partial class Dashboard : Form, IDashboardContract
    {
        //The main central clock that handles all information retrieval, processing, and output
        private CentralClock _centralClock;
	    private ImageClock _imageClock;

        public Dashboard()
        {
            InitializeComponent();

            AppConsole.AppConsole.RegisterTextbox(appConsole);
            AppConsole.AppConsole.RedirectConsoleOutput();

            _centralClock = new CentralClock(this);

            _centralClock.FrameGenerated += CentralClockOnFrameGenerated;
            _centralClock.StateGenerated += CentralClockOnStateGenerated;
            _centralClock.DataGenerated += CentralClockOnDataGenerated;

            LogicMapper.RobotClient.Start();

            ApplicationConfig.ConfigUpdated += (config) =>
            {
                auxVideoStream.MJPEGUrl = config.AuxVideoUrl;
                mainVideoStream.MJPEGUrl = config.MainVideoUrl;
                _imageClock.DelayInSeconds = config.ImageDelay;
            };

            auxVideoStream.MJPEGUrl = ApplicationConfig.Shared.AuxVideoUrl;
            mainVideoStream.MJPEGUrl = ApplicationConfig.Shared.MainVideoUrl;

			_imageClock = new ImageClock(ApplicationConfig.Shared.ImageDelay);

			LogicMapper.InputProcessor.ButtonPress += InputProcessorOnButtonPress;
        }

        #region Processing Event Handlers

        private void CentralClockOnDataGenerated(object responseData)
        {
            BeginInvoke((Action) (() =>
            {
                LogicMapper.DashboardModifier.OnDataRecieved(this, _centralClock, responseData);
            }));
        }

        private void CentralClockOnStateGenerated(GamePadState gamePadState)
        {
            BeginInvoke((Action) (() =>
            {
                leftThumbstick.StickValue = gamePadState.ThumbSticks.Left;
                rightThumbstick.StickValue = gamePadState.ThumbSticks.Right;

                leftTrigger.Value = (int) (gamePadState.Triggers.Left*100.0);
                rightTrigger.Value = (int) (gamePadState.Triggers.Right*100.0);

                LogicMapper.DashboardModifier.OnStateGenerated(this, _centralClock, gamePadState);
            }));
        }

        private void CentralClockOnFrameGenerated(RobotFrame robotFrame)
        {
            BeginInvoke((Action) (() =>
            {
                LogicMapper.DashboardModifier.OnRobotFrameGenerated(this, _centralClock, robotFrame);

                propA.Value = (int)(robotFrame.Motors.ThrusterA.Value*100);
                propB.Value = (int)(robotFrame.Motors.ThrusterB.Value*100);
                propC.Value = (int)(robotFrame.Motors.ThrusterC.Value*100);

                var lightColor = robotFrame.LightIsOn ? Color.Chartreuse : Color.Red;
                if (lblLight.BackColor != lightColor)
                    lblLight.BackColor = lightColor;

                //Servo Tab
                if (outputTabs.SelectedIndex == 2)
                {
                    servo1.Angle = robotFrame.Servos.Servo1.Angle;
                    servo2.Angle = robotFrame.Servos.Servo2.Angle;
                    servo3.Angle = robotFrame.Servos.Servo3.Angle;
                    servo4.Angle = robotFrame.Servos.Servo4.Angle;
                }

                lblServo.Text = ApplicationConfig.Shared.ServoCoefficient.ToString("F2");
            }));
        }

        private void InputProcessorOnButtonPress(GamePadButton gamePadButton)
        {
            BeginInvoke((Action) (() =>
            {
                if (gamePadButton == GamePadButton.RBumper)
                {
                    //Switch video streams
	                MJPEGVideo large, small;

	                if (mainVideoStream.Size.Area() > auxVideoStream.Size.Area())
	                {
		                //Main is larger
		                large = mainVideoStream;
		                small = auxVideoStream;

	                }
	                else
	                {
		                //Aux is larger
		                large = auxVideoStream;
		                small = mainVideoStream;
	                }

					var largeSize = large.Size;
					var largePos = large.Location;

					large.Size = small.Size;
					large.Location = auxVideoStream.Location;

	                small.Size = largeSize;
	                small.Location = largePos;

                }
                else if (gamePadButton == GamePadButton.DPadRight)
                {
                    if (outputTabs.SelectedIndex < outputTabs.TabCount - 1)
                        outputTabs.SelectedIndex++;
                }
                else if (gamePadButton == GamePadButton.DPadLeft)
                {
                    if (outputTabs.SelectedIndex > 0)
                        outputTabs.SelectedIndex--;
                }
            }));
        }

        #endregion

        #region Form Event Handlers

        #region Form

        private void Dashboard_Load(object sender, EventArgs e)
        {
            _centralClock.Start();
        }

        #endregion

        #region Tool Strip

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settings = new Settings();
            settings.ShowDialog();
        }

        private void saveConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.CreatePrompt = true;
            sfd.OverwritePrompt = true;
            sfd.AddExtension = true;
            sfd.DefaultExt = ".json";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ApplicationConfig.Save(ApplicationConfig.Shared, sfd.FileName);
            }
        }

        private void loadConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.Multiselect = false;
            ofd.DefaultExt = ".json";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ApplicationConfig.Load(ofd.FileName);
            }
        }

        #endregion

        #endregion

        #region Exposed Properties

        public string LThrusterMode
        {
            get { return lblLThrusterMode.Text; }
            set { lblLThrusterMode.Text = value; }
        }

        public string LThrusterPower
        {
            get { return lblLThrusterPower.Text; }
            set { lblLThrusterPower.Text = value; }
        }

        public string CpuTemp
        {
            get { return lblCpuTemp.Text; }
            set { lblCpuTemp.Text = value; }
        }

        public string Depth
        {
            get { return lblDepth.Text; }
            set { lblDepth.Text = value; }
        }

        public string WaterTemp
        {
            get { return lblWaterTemp.Text; }
            set { lblWaterTemp.Text = value; }
        }

        public string VThrusterMode
        {
            get { return lblVThrusterMode.Text; }
            set { lblVThrusterMode.Text = value; }
        }

        public string VThrusterPower
        {
            get { return lblVThrusterPower.Text; }
            set { lblVThrusterPower.Text = value; }
        }

        public string Voltage
        {
            get { return lblVoltage.Text; }
            set { lblVoltage.Text = value; }
        }

        public string QualityCommand
        {
            get { return lblQualityCommand.Text; }
            set { lblQualityCommand.Text = value; }
        }

        public string MessageTime
        {
            get { return lblMessageTime.Text; }
            set { lblMessageTime.Text = value; }
        }

        public string RThrusterMode
        {
            get { return lblRThrusterMode.Text; }
            set { lblRThrusterMode.Text = value; }
        }

        public string RThrusterPower
        {
            get { return lblRThrusterPower.Text; }
            set { lblRThrusterPower.Text = value; }
        }

        public string Sensor1
        {
            get { return lblSensor1.Text; }
            set { lblSensor1.Text = value; }
        }

        public string Sensor2
        {
            get { return lblSensor2.Text; }
            set { lblSensor2.Text = value; }
        }

        public string Sensor3
        {
            get { return lblSensor3.Text; }
            set { lblSensor3.Text = value; }
        }

        public int SelectedTab => outputTabs.SelectedIndex;

        public Chart Chart => chart;

		#endregion

		private void btnImageCap_Click(object sender, EventArgs e)
		{
			if (_imageClock.IsRunning)
			{
				_imageClock.Stop();
				btnImageCap.BackColor = Color.Red;
			}
			else
			{
				_imageClock.Start();
				btnImageCap.BackColor = Color.LimeGreen;
			}
		}
	}
}
