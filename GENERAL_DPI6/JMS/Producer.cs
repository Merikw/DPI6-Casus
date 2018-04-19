using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

using GENERAL_DPI6.Global;
using GENERAL_DPI6.Models.Connection;
using Newtonsoft.Json;

namespace GENERAL_DPI6.JMS
{
    public class Producer
    {
        private string QueueName;
        private ConnectionFactory connectionFactory;

        public Producer(string queueName = "")
        {
            connectionFactory = new ConnectionFactory();
            connectionFactory.HostName = GLOBAL.HOST_NAME;
            connectionFactory.Port = GLOBAL.PORT;

            QueueName = queueName;
        }

        public void SendConnectionRequest(ConnectionRequest connectionRequest)
        {
            using (var connection = connectionFactory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: QueueName,
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                string message = JsonConvert.SerializeObject(connectionRequest);

                IBasicProperties properties = channel.CreateBasicProperties();

                properties.Persistent = true;

                channel.BasicPublish(exchange: "",
                                     routingKey: QueueName,
                                     basicProperties: properties,
                                     body: Encoding.UTF8.GetBytes(message));
            }
        }
    }
}
