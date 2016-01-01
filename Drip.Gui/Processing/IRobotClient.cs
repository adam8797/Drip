using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drip.Gui.Processing;
using Illinois.SeaPerch.Net;

namespace Drip.Gui.CustomLogic
{
    public interface IRobotClient
    {
        void SendFrame(RobotFrame frame);

        ResponseData LatestData { get; }
    }
}
