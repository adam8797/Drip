using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Illinois.SeaPerch.Net
{
  /// <summary>
  /// Information on a received rover packet.
  /// </summary>
  public class RoverPacketReceivedEventArgs
  {
    public bool IsValid { get; set; }

    public ResponseData ResponseData { get; set; }

    public RoverPacketReceivedEventArgs(bool isValid, ResponseData data)
    {
      this.IsValid = isValid;
      this.ResponseData = data;
    }
  }
}
