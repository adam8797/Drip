using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drip.Gui.Api;
using Drip.Gui.Processing;
using Illinois.SeaPerch.Net;

namespace Drip.Gui.CustomLogic
{
    public static class LogicMapper<T>
    {
        public static readonly SubProcessor<MotorSubFrame> MotorSubFrameProcessor;
        public static readonly SubProcessor<ServoSubFrame> ServoSubFrameProcessor;
        public static readonly RobotClient<T> RobotClient;
        public static readonly InputProcessor InputProcessor;
        public static readonly IDashboardModifier<T> DashboardModifier; 

        static LogicMapper()
        {
            //Use this class to set which classes the program should use in processing
            //Simply change any of the objects below to read = new YOURCLASSHERE();

            MotorSubFrameProcessor = new SchiavoneMotorSubProcessor();
            ServoSubFrameProcessor = new NullServoSubProcessor();
            RobotClient = new RobotClient<T>();
            InputProcessor = new SchiavoneInputProcessor();
            DashboardModifier = new DefaultDashboardModifier<T>();
        }

    }
}
