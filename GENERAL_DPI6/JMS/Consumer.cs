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
        private ConnectionFactory connectionFactory;

        public Consumer()
        {
            connectionFactory = new ConnectionFactory();
            connectionFactory.HostName = GLOBAL.HOST_NAME;
            connectionFactory.Port = GLOBAL.PORT;
        }

        public void SendConnectionRequest()
        {

        }
    }
}
