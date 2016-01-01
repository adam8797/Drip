using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Illinois.SeaPerch.Net
{
  /// <summary>
  /// This class handles TCP communication from the client (e.g. PC/android) to the server (e.g. the rover).
  /// </summary>
  public class NetClient
  {
    //private Thread readThread;
    private IPAddress remoteIp;
    private int remotePort;
    //private bool terminateConnection;
    private TcpClient client;
    private NetworkStream clientStream;

    /// <summary>
    /// Creates the client
    /// </summary>
    /// <param name="serverIp"></param>
    /// <param name="serverPort"></param>
    public NetClient(IPAddress serverIp, int serverPort)
    {
      this.remoteIp = serverIp;
      this.remotePort = serverPort;
      //this.readThread = new Thread(new ThreadStart(ClientReadThread));
      //this.readThread.Start();

      this.client = null;
      this.clientStream = null;
      //try
      //{
        client = new TcpClient();
        IPEndPoint serverEndPoint = new IPEndPoint(this.remoteIp, this.remotePort);
        client.Connect(serverEndPoint);
        //log.Info("Connected to server " + this.remoteIp.ToString());

        this.clientStream = client.GetStream();
      //}
      //catch (Exception ex)
      //{
      //  Debug.WriteLine("Client failed: " + ex.Message);
      //  if (clientStream != null)
      //  {
      //    clientStream.Close();
      //  }
      //  if (client != null)
      //  {
      //    client.Close();
      //  }
      //}
    }

    //private void ClientReadThread()
    //{
    //  // This loop is to reconnect if necessary
    //  while (true)
    //  {

    //    while (!this.terminateConnection)
    //    {
    //      // Do nothing.  Information is written to 
    //    }
    //  }
    //}

    /// <summary>
    /// Sends a message to the server, and then returns the response from the server.
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public string WriteMessage(string message)
    {
      if (this.clientStream == null)
      {
        return "";
      }


      try
      {
        ASCIIEncoding enc = new ASCIIEncoding();
        byte[] messageBytes = enc.GetBytes(message);
        clientStream.Write(messageBytes, 0, messageBytes.Length);
        clientStream.Flush();

        byte[] responseBytes = new byte[1024];
        int bytesRead = 0;
        try
        {
          bytesRead = clientStream.Read(responseBytes, 0, 1024);
        }
        catch
        {
          Debug.WriteLine("{CLI} response timeout");
          return "";
        }

        if (bytesRead == 0)
        {
          Debug.WriteLine("{CLI} failed to read response");
          return "";
        }

        string response = enc.GetString(responseBytes, 0, bytesRead);
        //Debug.WriteLine("{CLI} " + response);

        return response;
      }
      catch
      {
        this.clientStream = null;
        return null;
      }
    }

    public void Close()
    {
      this.clientStream.Close();
      this.client.Close();
    }
  }
}
