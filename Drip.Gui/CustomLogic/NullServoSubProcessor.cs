using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drip.Gui.Api;
using Drip.Gui.Processing;
using XInputDotNetPure;

namespace Drip.Gui.CustomLogic
{
    public class NullServoSubProcessor : SubProcessor<ServoSubFrame> 
    {
        public override ServoSubFrame GenerateSubFrame(GamePadState state, RobotFrame previousFrame)
        {
            if (previousFrame == null)
                return new ServoSubFrame();

            var servos = previousFrame.Servos;

            if (state.Buttons.A == ButtonState.Pressed)
            {
                servos.Servo1.SetVelocity(1.0f);
            }
            else if (state.Buttons.B == ButtonState.Pressed)
            {
                servos.Servo1.SetVelocity(-1.0f);
            }
            else
            {
                servos.Servo1.SetVelocity(0.0f);
            }

            return servos;
        }
    }
}
