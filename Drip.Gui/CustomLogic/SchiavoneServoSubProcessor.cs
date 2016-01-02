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
    public class SchiavoneServoSubProcessor : SubProcessor<ServoSubFrame>
    {
        public override ServoSubFrame GenerateSubFrame(GamePadState state, RobotFrame previousFrame)
        {
            //This is the only time we should be making a new servo sub frame. When previousFrame == null this is the first loop
            if (previousFrame == null)
                return new ServoSubFrame(); 

            //Remember, in this method we do not create a new ServoSubFrame. That gets recycled each time.
            var servos = previousFrame.Servos;

            var vel = state.Triggers.Right - state.Triggers.Left;

            servos.Servo1.SetVelocity(vel);
            servos.Servo2.SetVelocity(vel);
            servos.Servo3.SetVelocity(-1.0f * vel);
            servos.Servo4.SetVelocity(-1.0f * vel);

            return servos;


        }
    }
}
