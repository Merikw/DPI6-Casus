using GENERAL_DPI6.Global;
using GENERAL_DPI6.Models;
using GENERAL_DPI6.Models.Connection;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERAL_DPI6.JMS
{
    public class Client
    {
        private IBasicProperties props;
        private readonly IConnection connection;
        private readonly IModel channel;

        public Client()
        {
            ConnectionFactory connectionFactory = new ConnectionFactory();
            connectionFactory.HostName = GLOBAL.HOST_NAME;
            connectionFactory.Port = GLOBAL.PORT;

            connection = connectionFactory.CreateConnection();
            channel = connection.CreateModel();

            props = channel.CreateBasicProperties();
            props.CorrelationId = Guid.NewGuid().ToString();
            props.ReplyTo = channel.QueueDeclare().QueueName;
            props.Persistent = true;

            channel.QueueDeclare(queue: GLOBAL.CONNECTION_REQUEST_WORKER_QUEUE,
                     durable: false,
                     exclusive: false,
                     autoDelete: false,
                     arguments: null);
        }

        public void SendConnectionRequest(RequestReply<ConnectionRequest, ConnectionReply> connectionRequest)
        {
            string message = JsonConvert.SerializeObject(connectionRequest);

            channel.BasicPublish(exchange: "",
                                 routingKey: GLOBAL.CONNECTION_REQUEST_WORKER_QUEUE,
                                 basicProperties: props,
                                 body: Encoding.UTF8.GetBytes(message));
        }
    }
}
