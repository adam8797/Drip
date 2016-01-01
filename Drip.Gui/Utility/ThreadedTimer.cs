using System;
using System.Threading;
using System.Windows.Forms;

namespace Drip.Gui.Utility
{
    public class ThreadedTimer
    {
        private Form _target;
        private Action _method;
        private Thread _thread;
        private int _time;
        public ThreadedTimer(Action method, Form target, int time)
        {
            _method = method;
            _target = target;
            _time = time;
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
                if ((DateTime.Now - lastTick[0]).Ticks >= (_time * TimeSpan.TicksPerMillisecond) - adjuctTicks)
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
