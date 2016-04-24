using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Illinois.SeaPerch.Net;
using XInputDotNetPure;

namespace Drip.Gui.Utility
{
    public static class Util
    {
        public static bool CompareSticks(this GamePadThumbSticks.StickValue sticka, GamePadThumbSticks.StickValue stickb)
        {
            return sticka.X.Equals(stickb.X) && sticka.Y.Equals(stickb.Y);
        }

	    public static long Area(this Size s)
	    {
		    return s.Height*s.Width;
	    }
    }
}
