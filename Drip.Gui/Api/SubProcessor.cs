using Drip.Gui.Processing;
using XInputDotNetPure;

namespace Drip.Gui.Api
{
    public class SubProcessor<T> where T: ISubFrame, new()
    {
        public virtual T GenerateSubFrame(GamePadState state, RobotFrame previousFrame)
        {
            return new T();
        }
    }
}
