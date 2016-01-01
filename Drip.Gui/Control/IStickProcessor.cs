using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drip.Gui.Processing;
using XInputDotNetPure;

namespace Drip.Gui.Control
{
    public interface IStickProcessor
    {
        MotorSubFrame GenerateFrame(GamePadState state);
    }
}
