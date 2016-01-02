using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using Drip.Gui.Api;
using Drip.Gui.Processing;
using XInputDotNetPure;

namespace Drip.Gui.CustomLogic
{
    public class SchiavoneMotorSubProcessor : SubProcessor<MotorSubFrame>
    {
        public override MotorSubFrame GenerateSubFrame(GamePadState state, RobotFrame previousFrame)
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
