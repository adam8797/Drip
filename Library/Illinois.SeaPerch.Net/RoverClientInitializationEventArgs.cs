using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Illinois.SeaPerch.Net
{
  /// <summary>
  /// Information on an initialization event
  /// </summary>
  public class RoverClientInitializationEventArgs
  {
    public bool IsConnected { get; internal set; }

    public RoverClientInitializationEventArgs(bool isConnected)
    {
      IsConnected = isConnected;
    }
  }
}
