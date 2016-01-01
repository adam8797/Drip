using System;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Drip.Gui.Utility;
using XInputDotNetPure;
using Timer = System.Timers.Timer;

namespace Drip.Gui.Processing
{
    public class CentralClock
    {
        private bool _supressTimer = false;
        private ThreadedTimer _timer;
        public InputProcessor InputProcessor;

        public CentralClock(Form caller)
        {
            InputProcessor = new InputProcessor();
            _timer = new ThreadedTimer(() =>
            {
                if (_supressTimer)
                    return;

                var padState = GamePad.GetState(PlayerIndex.One, GamePadDeadZone.IndependentAxes);
                StateGenerated?.Invoke(padState);

                //Process Gamepad
                var frame = CustomLogic.LogicMapper.InputProcessor.ProcessGamepad(padState);
                FrameGenerated?.Invoke(frame);

                //Get Sensor Data


                //Update Video

                //Send new commands
                var c = CustomLogic.LogicMapper.RobotClient;
                c.SendFrame(frame);

            }, caller, 100);
        }

        public event Action<RobotFrame> FrameGenerated;
        public event Action<GamePadState> StateGenerated;

        public void Stop()
        {
            _timer.Abort();
        }

        public void Start()
        {
            _timer.Start();
        }
    }
}
