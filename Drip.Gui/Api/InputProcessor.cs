using System;
using System.Diagnostics;
using Drip.Gui.Processing;
using Drip.Gui.Utility;
using XInputDotNetPure;

namespace Drip.Gui.Api
{
    public abstract class InputProcessor
    {
        public virtual RobotFrame ProcessData(GamePadState state, RobotFrame previousFrame)
        {
            return new RobotFrame()
            {
                Motors = new MotorSubFrame(),
                Servos = new ServoSubFrame(),
            };
        }

        protected void InvokeButtonPress(GamePadButton b)
        {
            AppConsole.WriteLine("Button Press: " + b, EventLevel.Debugging);
            ButtonPress?.Invoke(b);
        }

        public event Action<GamePadButton> ButtonPress;
    }
}