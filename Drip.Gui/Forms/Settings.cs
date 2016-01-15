using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Drip.AppConsole;
using Drip.Gui.Utility;
using XInputDotNetPure;

namespace Drip.Gui.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var cfg = new ApplicationConfig()
            {
                AuxVideoUrl = auxVideoUrl.Text,
                MainVideoUrl = mainVideoUrl.Text,
                RoverIp = robotIp.Text,
                RoverPort = robotPort.Text,
                ServoCoefficient = velCoeff.Value,
                UpdateRate = (int) fps.Value,
                DeadZone = (GamePadDeadZone)deadZone.SelectedIndex,
                FramesShownInGraph = (int)numFrames.Value,
                YMaximum = numYMax.Value,
                YMinimum = numYMin.Value,
                LoggingLevel = (EventLevel)loggingLevel.SelectedIndex
            };

            ApplicationConfig.Shared = cfg;

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            var cfg = ApplicationConfig.Shared;

            mainVideoUrl.Text = cfg.MainVideoUrl;
            auxVideoUrl.Text = cfg.AuxVideoUrl;
            velCoeff.Value = cfg.ServoCoefficient;
            fps.Value = cfg.UpdateRate;
            robotIp.Text = cfg.RoverIp;
            robotPort.Text = cfg.RoverPort;
            deadZone.SelectedIndex = (int) cfg.DeadZone;
            numFrames.Value = cfg.FramesShownInGraph;
            numYMax.Value = cfg.YMaximum;
            numYMin.Value = cfg.YMinimum;
            loggingLevel.SelectedIndex = (int)cfg.LoggingLevel;
        }
    }
}
