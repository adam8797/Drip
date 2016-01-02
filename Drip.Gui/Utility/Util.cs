using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XInputDotNetPure;

namespace Drip.Gui.Utility
{
    public static class Util
    {
        public static bool CompareSticks(this GamePadThumbSticks.StickValue sticka, GamePadThumbSticks.StickValue stickb)
        {
            return sticka.X.Equals(stickb.X) && sticka.Y.Equals(stickb.Y);
        }
    }
}
