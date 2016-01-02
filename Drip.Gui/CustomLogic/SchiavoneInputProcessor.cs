using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drip.Gui.Api;
using Drip.Gui.Processing;
using XInputDotNetPure;

namespace Drip.Gui.CustomLogic
{
    public class SchiavoneInputProcessor : InputProcessor
    {
        private GamePadState _previousGamePadState;

        public override RobotFrame ProcessData(GamePadState state, RobotFrame previousFrame)
        {
            //LT - Open Gripper
            //RT - Close Gripper

            var f = new RobotFrame();

            //Add all button states to the frame
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

            //Add all previous variable states.
            if (previousFrame != null)
            {
                f.LightIsOn = previousFrame.LightIsOn;
            }


            //Compare all the buttons. If their state has changed since the last frame, then we can call the event
            //So, heres what you do to add events: Follow the example bellow. I use RightBumper for the light, so that
            //is a simple example

            // ============== Example ==============


            if (
                Compare( //The compare function will only return true if the button is being pressed (rising),
                         //ie. has changed from "NotPressed" to "Pressed"

                    _previousGamePadState, //The state of the game pad LAST time the loop ran

                    state, //The current state of the game pad

                    s => s.Buttons.LeftShoulder)) //A lambda expression to choose the property to compare.
                                                  //In this case we want to see if LeftShoulder changed
            {
                //When we get here, we know the button has been pressed down.

                //This will notify all other classes that are listening for button presses. Make sure this gets called.
                //It can be called before your work, or after.
                InvokeButtonPress(GamePadButton.LBumper);

                //Now we can do whatever work we want to when the button gets pressed.
                //In this case, we'll just invert the boolean variable for LightIsOn in the frame

                //Note the elvis operator (?.) and the null coalesce here.
                //you cannot guarantee on the first run that _previousFrame will not be null. Account for it. 
                f.LightIsOn = (!previousFrame?.LightIsOn) ?? false;
            }

            //You can compact this down (without all the comments) into

            //if (Compare(_previousGamePadState, state, s => s.Buttons.LeftShoulder)) 
            //{
            //    InvokeButtonPress(GamePadButton.LBumper);
            //    f.LightIsOn = !_previousFrame?.LightIsOn ?? false;
            //}

            // ============== End Example ==============

            if (Compare(_previousGamePadState, state, s => s.Buttons.Start))
                InvokeButtonPress(GamePadButton.Start);
            if (Compare(_previousGamePadState, state, s => s.Buttons.A))
                InvokeButtonPress(GamePadButton.A);
            if (Compare(_previousGamePadState, state, s => s.Buttons.B))
                InvokeButtonPress(GamePadButton.B);
            if (Compare(_previousGamePadState, state, s => s.Buttons.Back))
                InvokeButtonPress(GamePadButton.Select);
            if (Compare(_previousGamePadState, state, s => s.Buttons.Guide))
                InvokeButtonPress(GamePadButton.Xbox);
            if (Compare(_previousGamePadState, state, s => s.Buttons.RightShoulder))
                InvokeButtonPress(GamePadButton.RBumper);
            if (Compare(_previousGamePadState, state, s => s.Buttons.LeftStick))
                InvokeButtonPress(GamePadButton.LStick);
            if (Compare(_previousGamePadState, state, s => s.Buttons.RightStick))
                InvokeButtonPress(GamePadButton.RStick);
            if (Compare(_previousGamePadState, state, s => s.Buttons.X))
                InvokeButtonPress(GamePadButton.X);
            if (Compare(_previousGamePadState, state, s => s.Buttons.Y))
                InvokeButtonPress(GamePadButton.Y);

            //Dpad
            if (Compare(_previousGamePadState, state, s => s.DPad.Up))
                InvokeButtonPress(GamePadButton.DPadUp);
            if (Compare(_previousGamePadState, state, s => s.DPad.Down))
                InvokeButtonPress(GamePadButton.DPadDown);
            if (Compare(_previousGamePadState, state, s => s.DPad.Left))
                InvokeButtonPress(GamePadButton.DPadLeft);
            if (Compare(_previousGamePadState, state, s => s.DPad.Right))
                InvokeButtonPress(GamePadButton.DPadRight);


            //Process the joysticks into a motor sub-frame
            f.Motors = LogicMapper.MotorSubFrameProcessor.GenerateSubFrame(state, previousFrame);

            //Process the joysticks into a servo sub-frame
            f.Servos = LogicMapper.ServoSubFrameProcessor.GenerateSubFrame(state, previousFrame);

            



            _previousGamePadState = state;
            return f;
        }

        private bool Compare(GamePadState previous, GamePadState current, Func<GamePadState, ButtonState> select)
        {
            return select(previous) == ButtonState.Released && select(current) == ButtonState.Pressed;
        }
    }
}
