using GENERAL_DPI6.Global;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERAL_DPI6.JMS
{
    public class TransportCompany
    {
        private readonly IConnection connection;

        private IBasicProperties propsReceiveConnectionRequest;
        private readonly IModel channelReceiveConnectionRequest;
        private string queueNameReceiveConnectionRequest;

        public TransportCompany()
        {
            ConnectionFactory connectionFactory = new ConnectionFactory();
            connectionFactory.HostName = GLOBAL.HOST_NAME;
            connectionFactory.Port = GLOBAL.PORT;

            connection = connectionFactory.CreateConnection();

            channelReceiveConnectionRequest = connection.CreateModel();

            channelReceiveConnectionRequest.ExchangeDeclare(exchange: GLOBAL.CONNECTION_REQUEST_TO_TRANSPORT_COMPANY_EXCHANGE, type: "direct");

            queueNameReceiveConnectionRequest = channelReceiveConnectionRequest.QueueDeclare().QueueName;

            channelReceiveConnectionRequest.QueueBind(queue: queueNameReceiveConnectionRequest,
                                  exchange: GLOBAL.CONNECTION_REQUEST_TO_TRANSPORT_COMPANY_EXCHANGE,
                                  routingKey: GLOBAL.TRANSPORT_DIRECT_ROUTING_KEY);
        }

        public void ListenToConnectionRequest()
        {
            var consumer = new EventingBasicConsumer(channelReceiveConnectionRequest);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body;
                var message = Encoding.UTF8.GetString(body);
                var routingKey = ea.RoutingKey;
                Console.WriteLine(" [x] Received '{0}':'{1}'",
                                  routingKey, message);
            };
            channelReceiveConnectionRequest.BasicConsume(queue: queueNameReceiveConnectionRequest,
                                 autoAck: true,
                                 consumer: consumer);
        }
    }
}
