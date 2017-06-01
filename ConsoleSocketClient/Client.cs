using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSocketClient
{
    class Client
    {
        public int port;

        public IPAddress remote;

        public Client(int port, IPAddress remote)
        {

            this.port = port;
            this.remote = remote;
        }
        public void Connect()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(new IPEndPoint(remote, port));
            
            //send message
            string sendStr = "send to server : hello,ni hao";
            byte[] sendBytes = Encoding.ASCII.GetBytes(sendStr);
            socket.Send(sendBytes);
            
            //receive message
            string recStr = "";
            byte[] recBytes = new byte[4096];
            int bytes = socket.Receive(recBytes, recBytes.Length, 0);
            recStr += Encoding.ASCII.GetString(recBytes, 0, bytes);
            Console.WriteLine(recStr);

            socket.Close();
        }
    }
}
