using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERAL_DPI6.Global
{
    public class GLOBAL
    {
        public static string HOST_NAME = "192.168.24.162";
        public static int PORT = 5672;
        public static string CONNECTION_REQUEST_WORKER_QUEUE = "CONNECTION_REQUEST_WORKER_QUEUE";
        public static string CONNECTION_REQUEST_TO_TRANSPORT_COMPANY_EXCHANGE = "CONNECTION_REQUEST_TO_TRANSPORT_COMPANY_EXCHANGE";
        public static string TRANSPORT_DIRECT_ROUTING_KEY = "TRANSPORT_ROUTING_KEY";
    }
}
