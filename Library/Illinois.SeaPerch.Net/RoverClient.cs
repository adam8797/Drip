using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Illinois.SeaPerch.Net
{
  /// <summary>
  /// This class handles communication between a client (e.g. desktop) and the rover.  It prepares the information
  /// to be sent to the rover and parses output from the rover.
  /// </summary>
  public class RoverClient
  {
    private Task netTask;
    private NetClient netClient;
    private bool exitThreads;
    private Thread netCommThread;
    private int[] cmdList;
    private Dictionary<string, int> errorCounts;


    /// <summary>
    /// The difference between data packets (in ms)
    /// </summary>
    private DateTime lastUpdateTime;
    private int avgUpdateDelta;
    private int updateCount;


    /// <summary>
    /// Rover IP address
    /// </summary>
    public string ServerIp { get; set; }

    /// <summary>
    /// Port to communicate on
    /// </summary>
    public string ServerPort { get; set; }
    
    /// <summary>
    /// Called when the communication is initiated (on failure or success)
    /// </summary>
    public event RoverCommInitiation RoverCommInitiation = delegate { };

    /// <summary>
    /// Called every time a packet is received
    /// </summary>
    public event RoverPacketReceived RoverPacketReceived = delegate { };

    /// <summary>
    /// The rate at which data is updated
    /// </summary>
    public int UpdateRate { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public RoverClient()
    {
      this.errorCounts = new Dictionary<string, int>();
    }

    /// <summary>
    /// Asynchronously starts up a network communication thread and starts communicating with the rover.  If the
    /// rover is not ready yet will keep trying.
    /// </summary>
    /// <returns></returns>
    public bool Start()
    {
      this.cmdList = new int[21];
      for (int i = 0; i < this.cmdList.Length; i++)
      {
        this.cmdList[i] = 0;
      }

      this.exitThreads = false;
      this.netCommThread = new Thread(new ThreadStart(NetCommThread));
      this.netCommThread.Start();

      if (this.netClient != null)
      {
        this.netClient.Close();
      }

      if (this.netTask == null || this.netTask.IsCompleted)
      {
        NetTask();
      }

      return true;
    }

    /// <summary>
    /// Starts up a thread that establishes and monitors the network connection and reestablishes it if necessary.
    /// </summary>
    private void NetTask()
    {
      this.netTask = Task.Run(() =>
      {
        //Debug.WriteLine("Running network task");
        //bool netRunning = false;
        //log.Info("Trying to connect to {0} on port {1}", this.ServerIp, this.ServerPort);
        while (!this.exitThreads)
        {
          if (this.netClient == null)
          {
            try
            {
              int portNum = int.Parse(this.ServerPort);
              this.netClient = new Net.NetClient(Net.NetUtil.GetIpAddressFromString(this.ServerIp), portNum);

              RoverCommInitiation(new RoverClientInitializationEventArgs(true));
              //this.Invoke((MethodInvoker)delegate()
              //{
              //  this.toolStripStatusNetwork.Image = Properties.Resources.network_status;
              //});
              ////break;
            }
            catch (Exception ex)
            {
              RoverCommInitiation(new RoverClientInitializationEventArgs(false));
              string msg = string.Format("Failed to connect to {0} on port {1}: {2}", this.ServerIp, this.ServerPort, ex.Message);
              //LogRepetitiveError(msg);
              //this.toolStripStatusNetwork.Image = Properties.Resources.network_status_busy;
              //Debug.WriteLine("Failed to connect to client " + this.ServerIp);
              //UiWarning("Unable to connect to rover");
              this.netClient = null;
            }
          }
          Thread.Sleep(2000);
        }
        //log.Debug("Net task done");
      });
    }

    /// <summary>
    /// This is the function for the rover communication thread.  It sends a buffer every period (100 ms)
    /// to the rover.  The buffer is updated from other threads.  If there are no updates within a given
    /// period the previous values are sent.
    /// </summary>
    private void NetCommThread()
    {
      while (!this.exitThreads)
      {
        string msg = "";
        lock (this.cmdList)
        {
          string fmt = "$CMD,{0},{1},{2:000},{3},{4:000},{5},{6:000},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19}\n";
          msg = string.Format(
            fmt,
            this.cmdList[0], this.cmdList[1], this.cmdList[2], this.cmdList[3], this.cmdList[4], this.cmdList[5], this.cmdList[6],
            this.cmdList[7], this.cmdList[8], this.cmdList[9], this.cmdList[10], this.cmdList[11], this.cmdList[12], this.cmdList[13],
            this.cmdList[14], this.cmdList[15], this.cmdList[16], this.cmdList[17], this.cmdList[18], this.cmdList[19]);
          /*
           * (Propellers A, CW,  56%; B, CCW, 25%  and C CCW 88%     )
              $CMD,0,1,56,2,25,2,88,1,0,0,0,0,0,0,0,0,0,0,0,0

              # Command Field 0  = reserved (send 0)
              # Command Field 1  = Propeller A - mode  [0 1 2 3]
              # Command Field 2  = Propeller A - speed [0...100]
              # Command Field 3  = Propeller B - mode  [0 1 2 3]
              # Command Field 4  = Propeller B - speed [0...100]
              # Command Field 5  = Propeller C - mode  [0 1 2 3]
              # Command Field 6  = Propeller C - speed [0...100]
              # Command Field 7  = Light 1 (ON) - 0 (OFF)  
              # Command Field 8  = AUX1  1(ON) - 0 (OFF)
              # Command Field 9  = AUX2  1(ON) - 0 (OFF)
              # Command Field 10 = reserved (send 0)  
              # Command Field 11 = reserved (send 0)
              # Command Field 12 = reserved (send 0)
              # Command Field 13 = reserved (send 0)
              # Command Field 14 = reserved (send 0)
              # Command Field 15 = reserved (send 0)
              # Command Field 16 = reserved (send 0)  
              # Command Field 17 = reserved (send 0)
              # Command Field 18 = 100
              # Command Field 19 = 1/0
              # Command Field 20 = HOLD POSITION  1(ON) - 0 (OFF)
           */
        }

        if (this.netClient != null)
        {
          //log.Debug("MSG_TO_ROVER: {0}", msg);
          string srvResponse = this.netClient.WriteMessage(msg);
          if (srvResponse == null)
          {
            this.netClient = null;
          }
          else
          {
            //Debug.WriteLine(srvResponse);
            ParseResponse(srvResponse);
          }
        }

        Thread.Sleep(100);
      }
    }

    private void ParseResponse(string srvResponse)
    {
      //                          2000-01-01 04:29:37.010437      0       0       0       0       0       0       0       0.00    0.75    55.00   0.34    0.75    0.50    0.51
      //datetime   QualityCMD  Propeller_A_MODE  Propeller_A_SPEED Propeller_B_MODE  Propeller_B_SPEED Propeller_C_MODE  Propeller_C_SPEED Voltage     depth     CPUTEMP     WaterTemp    Sensor1    Sensor2     Sensor3

      if (srvResponse == null)
      {
        return;
      }

      string[] parts = srvResponse.Split('\t');

      ResponseData data = new ResponseData();

      if (parts.Length > 0)
      {
        if (!DateTime.TryParse(parts[0], out data.MessageTime))
        {
          Debug.WriteLine("Unable to parse date/time from rover");
        }
      }
      if (parts.Length > 1)
      {
        if (!int.TryParse(parts[1], out data.QualityCmd))
        {
        }
      }
      if (parts.Length > 2)
      {
        if (!int.TryParse(parts[2], out data.LeftThrusterMode))
        {
        }
      }
      if (parts.Length > 3)
      {
        if (!int.TryParse(parts[3], out data.LeftThrusterPower))
        {
        }
      }
      if (parts.Length > 4)
      {
        if (!int.TryParse(parts[4], out data.RightThrusterMode))
        {
        }
      }
      if (parts.Length > 5)
      {
        if (!int.TryParse(parts[5], out data.RightThrusterPower))
        {
        }
      }
      if (parts.Length > 6)
      {
        if (!int.TryParse(parts[6], out data.VertThrusterMode))
        {
        }
      }
      if (parts.Length > 7)
      {
        if (!int.TryParse(parts[7], out data.VertThrusterPower))
        {
        }
      }
      if (parts.Length > 8)
      {
        if (!double.TryParse(parts[8], out data.Voltage))
        {
        }
      }
      if (parts.Length > 9)
      {
        if (!double.TryParse(parts[9], out data.Depth))
        {
        }
      }
      if (parts.Length > 10)
      {
        if (!double.TryParse(parts[10], out data.CpuTemp))
        {
        }
      }
      if (parts.Length > 11)
      {
        if (!double.TryParse(parts[11], out data.WaterTemp))
        {
        }
      }
      if (parts.Length > 12)
      {
        if (!double.TryParse(parts[12], out data.Sensor1))
        {
        }
      }
      if (parts.Length > 13)
      {
        if (!double.TryParse(parts[13], out data.Sensor2))
        {
        }
      }
      if (parts.Length > 14)
      {
        if (!double.TryParse(parts[14], out data.Sensor3))
        {
        }
      }

      RoverPacketReceived(new RoverPacketReceivedEventArgs(true, data));

      UpdateFrameRate();
    }

    private void UpdateFrameRate()
    {
      int msDiff = (int)(DateTime.Now - this.lastUpdateTime).TotalMilliseconds;
      this.lastUpdateTime = DateTime.Now;
      this.avgUpdateDelta = (msDiff + this.avgUpdateDelta * this.updateCount) / (this.updateCount + 1);
      this.updateCount++;

      if (this.updateCount % 10 == 0)
      {
        this.UpdateRate = 1000 / this.avgUpdateDelta;
        this.updateCount = 0;
        this.avgUpdateDelta = 0;
      }
    }

    /// <summary>
    /// Stops communicating
    /// </summary>
    public void Stop()
    {
      this.exitThreads = true;

      if (!this.netCommThread.Join(300))
      {
        this.netCommThread.Abort();
      }

      if (this.netClient != null)
      {
        this.netClient.Close();
      }
    }

    /// <summary>
    /// Sets information in the buffer to send to the rover.
    /// </summary>
    /// <param name="field"></param>
    /// <param name="value"></param>
    public void SetVariable(CommandField field, int value)
    {
      lock (this.cmdList)
      {
        this.cmdList[(int)field] = value;
      }
    }

    /// <summary>
    /// Only log a certain amount of the same error to avoid filling up the log file
    /// </summary>
    /// <param name="msg"></param>
    //private void LogRepetitiveError(string msg)
    //{
    //  if (this.errorCounts.ContainsKey(msg))
    //  {
    //    if (this.errorCounts[msg]++ < 5)
    //      log.Error(msg);
    //    else
    //      log.Error(msg + " .... too many errors, not logging this error again");
    //  }
    //  else
    //  {
    //    this.errorCounts[msg] = 0;
    //  }
    //}
  }
}
