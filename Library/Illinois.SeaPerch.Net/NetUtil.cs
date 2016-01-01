using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Illinois.SeaPerch.Net
{
  public static class NetUtil
  {
    public static IPAddress GetLocalHostIpAddress()
    {
      IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
      foreach (IPAddress ip in host.AddressList)
      {
        if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
        {
          return ip;
        }
      }
      return IPAddress.Any;
    }

    public static IPAddress GetIpAddressFromString(string ipAddress)
    {
      return IPAddress.Parse(ipAddress);
    }
  }
}
