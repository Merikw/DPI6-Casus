using GENERAL_DPI6.Global;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERAL_DPI6.JMS
{
    public class Consumer
    {
        private string QueueName;
        private ConnectionFactory ConnectionFactory;

        public Consumer(string queueName = "")
        {
            QueueName = queueName;
            ConnectionFactory = new ConnectionFactory();
            ConnectionFactory.HostName = GLOBAL.HOST_NAME;
            ConnectionFactory.Port = GLOBAL.PORT;
        }

        public void SendConnectionRequest()
        {

        }
    }
}
