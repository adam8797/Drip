using System;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Drip.Gui.Utility;
using Illinois.SeaPerch.Net;
using ROVControl;
using XInputDotNetPure;
using Drip.Gui.CustomLogic;

namespace Drip.Gui.Processing
{
    public class CentralClock
    {
        private bool _supressTimer = false;
        private RobotFrame _previousFrame = null;
        private ThreadedTimer _timer;

        public int LastFrameIndex => _previousFrame.FrameNumber;
        
        public CentralClock(Form caller)
        {
            int delay = 1000/ApplicationConfig.Shared.UpdateRate;

            ApplicationConfig.ConfigUpdated += config =>
            {
                _timer.DelayTime = 1000/config.UpdateRate;
                LogicMapper.RobotClient.Recycle();
            };
            

            _timer = new ThreadedTimer(() =>
            {
                if (_supressTimer)
                    return;

                var padState = GamePad.GetState(PlayerIndex.One, ApplicationConfig.Shared.DeadZone);
                StateGenerated?.Invoke(padState);

                //Process Gamepad
                var frame = LogicMapper.InputProcessor.ProcessData(padState, _previousFrame);

                //Update the frame number
                if (_previousFrame != null)
                    frame.FrameNumber = _previousFrame.FrameNumber + 1;

                //Send an update tick to the servos
                //The trick with the servos, is that all in all we only ever make one ServoSubFrame.
                //It gets recycled ever tick so that the servos can calculate velocities
                frame.Servos.Servo1.Update();
                frame.Servos.Servo2.Update();
                frame.Servos.Servo3.Update();
                frame.Servos.Servo4.Update();


                //Send the frame to anybody who is listening
                FrameGenerated?.Invoke(frame);

                //Get Sensor Data and send it to anybody who is listening
                DataGenerated?.Invoke(LogicMapper.RobotClient.LatestData);

                //Update Video


                //Send new commands
                var c = LogicMapper.RobotClient;
                c.SendFrame(frame);

                //Stash the current frame away for the next loop.
                _previousFrame = frame;

            }, caller, delay);
        }

        public event Action<RobotFrame> FrameGenerated;
        public event Action<GamePadState> StateGenerated;
        public event Action<object> DataGenerated;

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
