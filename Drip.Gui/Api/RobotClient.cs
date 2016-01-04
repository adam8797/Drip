using Drip.Gui.Processing;
using Illinois.SeaPerch.Net;

namespace Drip.Gui.Api
{
    public class RobotClient<T>
    {
        public virtual void SendFrame(RobotFrame frame)
        {
            //Do nothing
        }

        public T LatestData { get; protected set; }
    }
}
