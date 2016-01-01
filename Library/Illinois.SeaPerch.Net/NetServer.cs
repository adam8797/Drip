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
  public delegate string MessageHandler(string msgFromClient);

  /// <summary>
  /// This is used for testing purposes (e.g. to simulate a remote rover).
  /// </summary>
  public class NetServer
  {
    private IPAddress localIp;
    private int listenPort;
    private TcpListener listener;
    private Thread listenThread;

    private MessageHandler handler = new MessageHandler(defaultHandler);

    public NetServer(int portNum, MessageHandler infoToClientHandler)
    {
      if (infoToClientHandler != null)
      {
        this.handler = infoToClientHandler;
      }

      this.listenPort = portNum;
      this.localIp = IPAddress.Any;
      this.listener = new TcpListener(this.localIp, this.listenPort);
    }

    public void Start()
    {
      this.listenThread = new Thread(new ThreadStart(ClientListener));
      this.listenThread.Start();
    }

    public void Stop()
    {
      this.listenThread.Abort();
      this.listener.Stop();
    }

    private void ClientListener()
    {
      Console.WriteLine("{SRV} Started");
      this.listener.Start();

      while (true)
      {
        TcpClient clientConn = listener.AcceptTcpClient();
        Console.WriteLine("{SRV} Got connection");

        new Thread(new ParameterizedThreadStart(HandleClient)).Start(clientConn);
      }
    }

    private void HandleClient(object obj)
    {
      TcpClient clientConn = obj as TcpClient;

      if (clientConn == null)
      {
        throw new Exception("HandleClient: Expected TcpClient");
      }

      NetworkStream clientStream = clientConn.GetStream();
      while (true)
      {
        byte[] messageBytes = new byte[1024];
        int bytesRead = 0;

        try
        {
          bytesRead = clientStream.Read(messageBytes, 0, 1024);
        }
        catch
        {
          Console.WriteLine("{SRV} read failed");
          break;
        }

        if (bytesRead == 0)
        {
          Console.WriteLine("{SRV} read timeout");
          break;
        }

        ASCIIEncoding enc = new ASCIIEncoding();
        string message = enc.GetString(messageBytes, 0, bytesRead);
        Debug.WriteLine("{SRV} recv " + message);

        byte[] response = enc.GetBytes(this.handler(message));
        clientStream.Write(response, 0, response.Length);
        clientStream.Flush();
      }

      clientConn.Close();
    }

    public static void Run()
    {
      IPAddress localIp = NetUtil.GetLocalHostIpAddress();
      TcpListener listener = new TcpListener(localIp, 8001);
      listener.Start();

      while (true)
      {
        TcpClient clientConn = listener.AcceptTcpClient();
        Console.WriteLine("{SRV} Got connection");
        NetworkStream clientStream = clientConn.GetStream();
        while (true)
        {
          byte[] message = new byte[1024];
          int bytesRead = 0;

          try
          {
            bytesRead = clientStream.Read(message, 0, 1024);
          }
          catch
          {
            Console.WriteLine("{SRV} read failed");
            break;
          }

          if (bytesRead == 0)
          {
            Console.WriteLine("{SRV} read timeout");
            break;
          }

          ASCIIEncoding enc = new ASCIIEncoding();
          Console.WriteLine("{SRV} " + enc.GetString(message, 0, bytesRead));

          byte[] response = enc.GetBytes("OK\n");
          clientStream.Write(response, 0, response.Length);
          clientStream.Flush();
        }

        clientConn.Close();
      }

      //listener.Stop();
    }

    private static string defaultHandler(string msgFromClient)
    {
      return "";
    }
  }
}
