using System;
using System.Threading;
using System.Windows.Forms;

namespace ROVControl
{
    /// <summary>
    /// A timer class that tries to be very precise with when it runs. Useful for recordings.
    /// Written for Orange Mango's entry to the 2015 MATE competition, from "ROVControl"
    /// </summary>
    public class ThreadedTimer
    {
        private Form _target;
        private Action _method;
        private Thread _thread;

        private static object threadLocker = new object();

        private int _delayTime;

        public int DelayTime
        {
            get
            {
                lock (threadLocker)
                {
                    return _delayTime;
                }
            }
            set
            {
                lock (threadLocker)
                {
                    _delayTime = value;
                }
            }
        }

        public ThreadedTimer(Action method, Form target, int time)
        {
            _method = method;
            _target = target;
            DelayTime = time;
            _thread = new Thread(ThreadAction);
        }

        public void Start()
        {
            _thread.Start();
        }

        public void Abort()
        {
            _thread.Abort();
            _thread = new Thread(ThreadAction);
        }

        private void ThreadAction()
        {
            DateTime[] lastTick = { DateTime.Now };
            long adjuctTicks = 0;
            while (true)
            {
                if ((DateTime.Now - lastTick[0]).Ticks >= (DelayTime * TimeSpan.TicksPerMillisecond) - adjuctTicks)
                {
                    lastTick[0] = DateTime.Now;

                    _target.Invoke(new MethodInvoker(() =>
                    {
                        _method?.Invoke();
                    }));

                    adjuctTicks = (DateTime.Now - lastTick[0]).Ticks;
                }
            }
        }
    }
}
