using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drip.Gui.Api;

namespace Drip.Gui.Processing
{
    public class MotorSubFrame : ISubFrame
    {
        public Motor ThrusterA { get; set; } = new Motor();
        public Motor ThrusterB { get; set; } = new Motor();
        public Motor ThrusterC { get; set; } = new Motor();
    }

    public class Motor
    {
        public double Value { get; set; } = 0;

        public int Mode
        {
            get
            {
                if (Value < 0)
                    return 1;

                if (Value > 0)
                    return 2;

                return 0;
            }
        }
    }
}
