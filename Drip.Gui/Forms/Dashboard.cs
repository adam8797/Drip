using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Drip.Gui.CustomLogic;
using Drip.Gui.Processing;
using Drip.Gui.Utility;
using Illinois.SeaPerch.Net;
using XInputDotNetPure;

namespace Drip.Gui.Forms
{
    public partial class Dashboard : Form
    {
        private CentralClock _centralClock;

        public Dashboard()
        {
            InitializeComponent();

            _centralClock = new CentralClock(this);

            _centralClock.FrameGenerated += CentralClockOnFrameGenerated;
            _centralClock.StateGenerated += CentralClockOnStateGenerated;
            _centralClock.DataGenerated += CentralClockOnDataGenerated;

            ApplicationConfig.ConfigUpdated += (config) =>
            {
                BindVideo();
            };

            BindVideo();

            LogicMapper.InputProcessor.ButtonPress += InputProcessorOnButtonPress;

        }

        private void CentralClockOnDataGenerated(ResponseData responseData)
        {
            //Update the data on the raw response tab.
            if (outputTabs.SelectedIndex == 1)
            {
                var form = "N3";

                //Left Column
                lblLThrusterMode.Text =     responseData.LeftThrusterMode.ToString();
                lblLThrusterPower.Text =    responseData.LeftThrusterPower.ToString();
                lblCpuTemp.Text =           responseData.CpuTemp.ToString(form);
                lblDepth.Text =             responseData.Depth.ToString(form);
                lblWaterTemp.Text =         responseData.WaterTemp.ToString(form);

                //Center Column
                lblVThrusterMode.Text =     responseData.VertThrusterMode.ToString();
                lblVThrusterPower.Text =    responseData.VertThrusterPower.ToString();
                lblVoltage.Text =           responseData.Voltage.ToString(form);
                lblQualityCommand.Text =    responseData.QualityCmd.ToString();
                lblMessageTime.Text =       responseData.MessageTime.ToString("HH:mm:ss.fff");

                //Right Column
                lblRThrusterMode.Text =     responseData.RightThrusterMode.ToString();
                lblRThrusterPower.Text =    responseData.RightThrusterPower.ToString();
                lblSensor1.Text =           responseData.Sensor1.ToString(form);
                lblSensor2.Text =           responseData.Sensor2.ToString(form);
                lblSensor3.Text =           responseData.Sensor3.ToString(form);
            }
        }

        private void InputProcessorOnButtonPress(GamePadButton gamePadButton)
        {
            BeginInvoke((Action) (() =>
            {
                if (gamePadButton == GamePadButton.RBumper)
                {
                    //Switch video streams
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

        private void CentralClockOnStateGenerated(GamePadState gamePadState)
        {
            BeginInvoke((Action) (() =>
            {
                leftThumbstick.StickValue = gamePadState.ThumbSticks.Left;
                rightThumbstick.StickValue = gamePadState.ThumbSticks.Right;

                leftTrigger.Value = (int) (gamePadState.Triggers.Left*100.0);
                rightTrigger.Value = (int) (gamePadState.Triggers.Right*100.0);
            }));
        }

        private void CentralClockOnFrameGenerated(RobotFrame robotFrame)
        {
            BeginInvoke((Action) (() =>
            {
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
            }));
        }

        private void BindVideo()
        {
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            _centralClock.Start();
        }

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
    }
}
