using Drip.Gui.Processing;
using Illinois.SeaPerch.Net;

namespace Drip.Gui.Api
{
    public class RobotClient
    {
        public virtual void SendFrame(RobotFrame frame)
        {
            //Do nothing
        }

        public ResponseData LatestData { get; protected set; }
    }
}
