using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drip.Gui.Processing
{
    public class MotorSubFrame
    {
        public Motor ThrusterA { get; set; }
        public Motor ThrusterB { get; set; }
        public Motor ThrusterC { get; set; }
    }

    public class Motor
    {
        public double Value { get; set; }

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
