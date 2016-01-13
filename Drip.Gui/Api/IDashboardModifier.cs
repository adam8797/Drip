using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drip.Gui.Processing;
using Ozeki.Common;
using XInputDotNetPure;

namespace Drip.Gui.Api
{
    public interface IDashboardModifier
    {
        void OnDataRecieved(IDashboardContract dash, CentralClock clock, object responseData);
        void OnStateGenerated(IDashboardContract dash, CentralClock clock, GamePadState state);
        void OnRobotFrameGenerated(IDashboardContract dash, CentralClock clock, RobotFrame frame);
    }
}
