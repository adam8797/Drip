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
    public interface IDashboardModifier<TResponseData>
    {
        void OnDataRecieved(IDashboardContract dash, CentralClock<TResponseData> clock, TResponseData responseData);
        void OnStateGenerated(IDashboardContract dash, CentralClock<TResponseData> clock, GamePadState state);
        void OnRobotFrameGenerated(IDashboardContract dash, CentralClock<TResponseData> clock, RobotFrame frame);
    }
}
