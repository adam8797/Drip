using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drip.Gui.Processing;
using Drip.Gui.Utility;
using Illinois.SeaPerch.Net;

namespace Drip.Gui.CustomLogic
{
    public class IllinoisRobotClient : IRobotClient
    {
        RoverClient _client = new RoverClient();

        public IllinoisRobotClient()
        {
            _client.ServerIp = ApplicationConfig.SharedApplicationConfig.RoverIp;
            _client.ServerPort = ApplicationConfig.SharedApplicationConfig.RoverPort;
            _client.UpdateRate = ApplicationConfig.SharedApplicationConfig.UpdateRate;
            _client.RoverCommInitiation += ClientOnRoverCommInitiation;
            _client.RoverPacketReceived += ClientOnRoverPacketReceived;
        }

        private void ClientOnRoverPacketReceived(RoverPacketReceivedEventArgs eventArgs)
        {
            LatestData = eventArgs.ResponseData;
            Debug.WriteLine("Recieved data");
        }

        private void ClientOnRoverCommInitiation(RoverClientInitializationEventArgs eventArgs)
        {
            Debug.WriteLine("Rover Client is connected");
        }

        public void SendFrame(RobotFrame frame)
        {
            _client.SetVariable(CommandField.PropellerA_mode, frame.Motors.ThrusterA.Mode);
            _client.SetVariable(CommandField.PropellerA_speed, (int)Math.Abs(frame.Motors.ThrusterA.Value * 100.0));

            _client.SetVariable(CommandField.PropellerB_mode, frame.Motors.ThrusterB.Mode);
            _client.SetVariable(CommandField.PropellerB_speed, (int)Math.Abs(frame.Motors.ThrusterB.Value * 100.0));

            _client.SetVariable(CommandField.PropellerC_mode, frame.Motors.ThrusterC.Mode);
            _client.SetVariable(CommandField.PropellerC_speed, (int)Math.Abs(frame.Motors.ThrusterC.Value * 100.0));

            _client.SetVariable(CommandField.Light, frame.Flags["lightIsOn"] ? 1:0);
        }

        public ResponseData LatestData { get; private set; }
    }
}
