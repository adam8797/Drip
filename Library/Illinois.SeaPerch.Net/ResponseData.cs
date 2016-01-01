using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Illinois.SeaPerch.Net
{
  /// <summary>
  /// This struct holds information coming from the rover.
  /// </summary>
  public struct ResponseData
  {
    public DateTime MessageTime;
    public int QualityCmd;
    public int LeftThrusterMode;
    public int LeftThrusterPower;
    public int RightThrusterMode;
    public int RightThrusterPower;
    public int VertThrusterMode;
    public int VertThrusterPower;
    public double Voltage;
    public double Depth;
    public double CpuTemp;
    public double WaterTemp;
    public double Sensor1;
    public double Sensor2;
    public double Sensor3;
  }
}
