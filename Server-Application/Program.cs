using GENERAL_DPI6.JMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            server.ListenToConnectionRequest();
            Console.ReadLine();
        }
    }
}
