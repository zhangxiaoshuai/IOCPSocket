using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSocketClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress remote = IPAddress.Parse("127.0.0.1");
            Client client = new Client(8088, remote);
            client.Connect();
            Console.ReadLine();
        }
    }
}
