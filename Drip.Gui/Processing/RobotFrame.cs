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

        public Dictionary<string, bool> Flags { get; set; } 

        public Dictionary<GamePadButton, ButtonState> Buttons { get; set; } = new Dictionary<GamePadButton, ButtonState>();
    }
}
