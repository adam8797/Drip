using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Illinois.SeaPerch.Net
{
  public delegate void RoverCommInitiation(RoverClientInitializationEventArgs eventArgs);
  public delegate void RoverPacketReceived(RoverPacketReceivedEventArgs eventArgs);
}
