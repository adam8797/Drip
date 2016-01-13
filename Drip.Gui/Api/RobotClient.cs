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

        public virtual void Start()
        {
            //Do nothing
        }

        public virtual void Recycle()
        {
            //Do nothing
        }

        public object LatestData { get; protected set; }
    }
}
