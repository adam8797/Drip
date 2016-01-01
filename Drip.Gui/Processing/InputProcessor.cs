using System;
using System.Diagnostics;
using Drip.Gui.CustomLogic;
using XInputDotNetPure;

namespace Drip.Gui.Processing
{
    public interface IInputProcessor
    {
        RobotFrame ProcessGamepad(GamePadState state);
        event Action<GamePadButton> ButtonPress;
    }

    public class InputProcessor
    {
        
    }

    public enum GamePadButton
    {
        A,
        B,
        X,
        Y,
        LStick,
        RStick,
        LBumper,
        RBumper,
        DPadUp,
        DPadDown,
        DPadLeft,
        DPadRight,
        Start,
        Select,
        Xbox
    }
}
