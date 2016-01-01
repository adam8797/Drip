using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drip.Gui.Control;
using Drip.Gui.Processing;
using Illinois.SeaPerch.Net;

namespace Drip.Gui.CustomLogic
{
    public static class LogicMapper
    {

        //Use this class to set which classes the program should use in processing

        public static IStickProcessor StickToMotorProcessor = new SchiavoneStickToMotorMapping();

        public static IRobotClient RobotClient = new IllinoisRobotClient();

        public static IInputProcessor InputProcessor = new BasicInputProcessor();


    }

    public class NullRobotClient : IRobotClient
    {
        public void SendFrame(RobotFrame frame)
        {
            
        }

        public ResponseData LatestData => default(ResponseData);
    }
}
