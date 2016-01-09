using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XInputDotNetPure;

namespace Drip.Gui.Processing
{
    public class RobotFrame
    {
        public MotorSubFrame Motors { get; set; }
        public ServoSubFrame Servos { get; set; }

        public int FrameNumber { get; set; }

        //Add ant more fields that you need here
        public bool LightIsOn { get; set; }
        //public bool camServoUP { get; set; }
        //public bool camServoDOWN { get; set; }

        public Dictionary<GamePadButton, ButtonState> Buttons { get; set; } = new Dictionary<GamePadButton, ButtonState>();
    }
}
