using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using Drip.Gui.Control;
using Drip.Gui.Processing;
using XInputDotNetPure;

namespace Drip.Gui.CustomLogic
{
    class SchiavoneStickToMotorMapping : IStickProcessor
    {
        private const double AnalogMid = .5;
        private const double AnalogLow = 0;
        private const double AnalogHigh = 1;
        private const double FrThresh = 0.3;


        public MotorSubFrame GenerateFrame(GamePadState state)
        {
            var leftThruster = new Motor();
            var rightThruster = new Motor();
            var vertThruster = new Motor();

            //Gross forward motion.
            leftThruster.Value = state.ThumbSticks.Left.Y;
            rightThruster.Value = state.ThumbSticks.Left.Y;

            //Take care of turning. Will reduce one motor and increase the other.
            leftThruster.Value += state.ThumbSticks.Left.X;
            rightThruster.Value -= state.ThumbSticks.Left.X;

            vertThruster.Value = state.ThumbSticks.Right.Y;

            Constrain(leftThruster);
            Constrain(rightThruster);
            Constrain(vertThruster);

            //Map the thrusters
            return new MotorSubFrame()
            {
                ThrusterA = leftThruster,
                ThrusterB = rightThruster,
                ThrusterC = vertThruster
            };
            //vertThruster.Direction = Math
        }

        private void Constrain(Motor m)
        {
            if (m.Value > 1)
                m.Value = 1;
            if (m.Value < -1)
                m.Value = -1;
        }
    }
}
