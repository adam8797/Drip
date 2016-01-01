using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drip.Gui.Processing;
using XInputDotNetPure;

namespace Drip.Gui.CustomLogic
{
    public class BasicInputProcessor : IInputProcessor
    {
        private GamePadState _previousGamePadState;

        public RobotFrame ProcessGamepad(GamePadState state)
        {
            //Left joystick is Rotation & Velocity
            //Right joystick is Vertical

            //LT - Open Gripper
            //RT - Close Gripper

            //RB - Switch Video Streams

            //LB - Light

            var f = new RobotFrame();

            //Add all states to the frame
            f.Buttons.Add(GamePadButton.Start, state.Buttons.Start);
            f.Buttons.Add(GamePadButton.A, state.Buttons.A);
            f.Buttons.Add(GamePadButton.B, state.Buttons.B);
            f.Buttons.Add(GamePadButton.Select, state.Buttons.Back);
            f.Buttons.Add(GamePadButton.Xbox, state.Buttons.Guide);
            f.Buttons.Add(GamePadButton.LBumper, state.Buttons.LeftShoulder);
            f.Buttons.Add(GamePadButton.LStick, state.Buttons.LeftStick);
            f.Buttons.Add(GamePadButton.RBumper, state.Buttons.RightShoulder);
            f.Buttons.Add(GamePadButton.RStick, state.Buttons.RightStick);
            f.Buttons.Add(GamePadButton.X, state.Buttons.X);
            f.Buttons.Add(GamePadButton.Y, state.Buttons.Y);


            //Compare all the buttons. If their state has changed since the last frame, then we can call the event
            if (Compare(_previousGamePadState, state, s => s.Buttons.Start))
                _buttonPress(GamePadButton.Start);
            if (Compare(_previousGamePadState, state, s => s.Buttons.A))
                _buttonPress(GamePadButton.A);
            if (Compare(_previousGamePadState, state, s => s.Buttons.B))
                _buttonPress(GamePadButton.B);
            if (Compare(_previousGamePadState, state, s => s.Buttons.Back))
                _buttonPress(GamePadButton.Select);
            if (Compare(_previousGamePadState, state, s => s.Buttons.Guide))
                _buttonPress(GamePadButton.Xbox);
            if (Compare(_previousGamePadState, state, s => s.Buttons.LeftShoulder))
                _buttonPress(GamePadButton.LBumper);
            if (Compare(_previousGamePadState, state, s => s.Buttons.LeftStick))
                _buttonPress(GamePadButton.LStick);
            if (Compare(_previousGamePadState, state, s => s.Buttons.RightShoulder))
                _buttonPress(GamePadButton.RBumper);
            if (Compare(_previousGamePadState, state, s => s.Buttons.RightStick))
                _buttonPress(GamePadButton.RStick);
            if (Compare(_previousGamePadState, state, s => s.Buttons.X))
                _buttonPress(GamePadButton.X);
            if (Compare(_previousGamePadState, state, s => s.Buttons.Y))
                _buttonPress(GamePadButton.Y);

            //Dpad
            if (Compare(_previousGamePadState, state, s => s.DPad.Up))
                _buttonPress(GamePadButton.DPadUp);
            if (Compare(_previousGamePadState, state, s => s.DPad.Down))
                _buttonPress(GamePadButton.DPadDown);
            if (Compare(_previousGamePadState, state, s => s.DPad.Left))
                _buttonPress(GamePadButton.DPadLeft);
            if (Compare(_previousGamePadState, state, s => s.DPad.Right))
                _buttonPress(GamePadButton.DPadRight);


            //Process the joysticks into motor
            f.Motors = LogicMapper.StickToMotorProcessor.GenerateFrame(state);

            _previousGamePadState = state;
            return f;
        }

        private void _buttonPress(GamePadButton b)
        {
            Debug.WriteLine("Button Press: " + b.ToString());
            ButtonPress?.Invoke(b);
        }

        public event Action<GamePadButton> ButtonPress;

        private bool Compare(GamePadState previous, GamePadState current, Func<GamePadState, ButtonState> select)
        {
            return select(previous) == ButtonState.Released && select(current) == ButtonState.Pressed;
        }
    }
}
