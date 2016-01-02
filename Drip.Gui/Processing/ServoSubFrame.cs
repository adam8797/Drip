using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drip.Gui.Api;
using ROVControl.Control;

namespace Drip.Gui.Processing
{
    public class ServoSubFrame : ISubFrame
    {
        public Servo Servo1 { get; set; } = new Servo();
        public Servo Servo2 { get; set; } = new Servo();
        public Servo Servo3 { get; set; } = new Servo();
        public Servo Servo4 { get; set; } = new Servo();
    }
}
