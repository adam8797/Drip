using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drip.Gui.Api;
using Drip.Gui.Processing;
using Drip.Gui.Utility;
using Illinois.SeaPerch.Net;

namespace Drip.Gui.CustomLogic
{
    public class IllinoisRobotClient : RobotClient<ResponseData>
    {
        private RoverClient _client;

        public IllinoisRobotClient()
        {
            _client = new RoverClient
            {
                ServerIp = ApplicationConfig.Shared.RoverIp,
                ServerPort = ApplicationConfig.Shared.RoverPort,
                UpdateRate = ApplicationConfig.Shared.UpdateRate
            };
            _client.RoverCommInitiation += ClientOnRoverCommInitiation;
            _client.RoverPacketReceived += ClientOnRoverPacketReceived;
        }

        private void ClientOnRoverPacketReceived(RoverPacketReceivedEventArgs eventArgs)
        {
            LatestData = eventArgs.ResponseData;
            AppConsole.WriteLine("Recieved data. Timestamp: " + eventArgs.ResponseData.MessageTime.ToString("G"), EventLevel.Debugging);
        }

        private void ClientOnRoverCommInitiation(RoverClientInitializationEventArgs eventArgs)
        {
            AppConsole.WriteLine("Rover Client is connected", EventLevel.Logging);
        }

        public override void SendFrame(RobotFrame frame)
        {
            //Standard old variables
            _client.SetVariable(CommandField.PropellerA_mode, frame.Motors.ThrusterA.Mode);
            _client.SetVariable(CommandField.PropellerA_speed, (int)Math.Abs(frame.Motors.ThrusterA.Value * 100.0));

            _client.SetVariable(CommandField.PropellerB_mode, frame.Motors.ThrusterB.Mode);
            _client.SetVariable(CommandField.PropellerB_speed, (int)Math.Abs(frame.Motors.ThrusterB.Value * 100.0));

            _client.SetVariable(CommandField.PropellerC_mode, frame.Motors.ThrusterC.Mode);
            _client.SetVariable(CommandField.PropellerC_speed, (int)Math.Abs(frame.Motors.ThrusterC.Value * 100.0));

            _client.SetVariable(CommandField.Light, frame.LightIsOn ? 1:0);

            //Servo
            //I've used command fields 21 - 24
            //They dont exist in the definition of CommandField, so they will have no name
            _client.SetVariable((CommandField)10, frame.Servos.Servo1.Angle);
            _client.SetVariable((CommandField)11, frame.Servos.Servo2.Angle);
            _client.SetVariable((CommandField)12, frame.Servos.Servo3.Angle);
            _client.SetVariable((CommandField)13, frame.Servos.Servo4.Angle);
        }
    }
}
