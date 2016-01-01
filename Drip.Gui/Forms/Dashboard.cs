using System;
using System.Diagnostics;
using System.Windows.Forms;
using Drip.Gui.CustomLogic;
using Drip.Gui.Processing;
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
            //_centralClock.Start();

            _centralClock.FrameGenerated += CentralClockOnFrameGenerated;
            _centralClock.StateGenerated += CentralClockOnStateGenerated;

            LogicMapper.InputProcessor.ButtonPress += InputProcessorOnButtonPress;

        }

        private void InputProcessorOnButtonPress(GamePadButton gamePadButton)
        {
            BeginInvoke((Action) (() =>
            {
                if (gamePadButton == GamePadButton.RBumper)
                {
                    //Switch video streams
                }
            }));
        }

        private void CentralClockOnStateGenerated(GamePadState gamePadState)
        {
            BeginInvoke((Action) (() =>
            {
                leftX.Value = (int)(100.0*gamePadState.ThumbSticks.Left.X);
                leftY.Value = (int)(100.0 * gamePadState.ThumbSticks.Left.Y);
                rightX.Value = (int)(100.0*gamePadState.ThumbSticks.Right.X);
                rightY.Value = (int)(100.0*gamePadState.ThumbSticks.Right.Y);
            }));
        }

        private void CentralClockOnFrameGenerated(RobotFrame robotFrame)
        {
            BeginInvoke((Action) (() =>
            {
                propA.Value = (int)(robotFrame.Motors.ThrusterA.Value * 100);
                propB.Value = (int) (robotFrame.Motors.ThrusterB.Value*100);
                propC.Value = (int) (robotFrame.Motors.ThrusterC.Value*100);
            }));
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            _centralClock.Start();
                
        }
    }
}
