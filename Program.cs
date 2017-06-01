using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleICOPSERVER
{
    class Program
    {
        static void Main(string[] args)
        {
            IOCPServer server = new IOCPServer(8088, 1024);
            server.Start();
            Console.WriteLine("服务器已启动....");
            System.Console.ReadLine();
        }
    }
}
