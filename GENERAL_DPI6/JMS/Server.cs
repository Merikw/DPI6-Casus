using GENERAL_DPI6.Global;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GENERAL_DPI6.JMS
{
    public class Server
    {
        private readonly IConnection connection;

        private IBasicProperties propsConnectionRequest;
        private readonly IModel channelConnectionRequest;

        private IBasicProperties propsConnectionRequestToTransportCompany;
        private readonly IModel channelConnectionRequestToTransportCompany;

        public Server()
        {
            ConnectionFactory connectionFactory = new ConnectionFactory();
            connectionFactory.HostName = GLOBAL.HOST_NAME;
            connectionFactory.Port = GLOBAL.PORT;

            connection = connectionFactory.CreateConnection();

            channelConnectionRequest = connection.CreateModel();
            channelConnectionRequest.BasicQos(0, 1, false);
            channelConnectionRequest.QueueDeclare(queue: GLOBAL.CONNECTION_REQUEST_WORKER_QUEUE,
                     durable: false,
                     exclusive: false,
                     autoDelete: false,
                     arguments: null);

            propsConnectionRequest = channelConnectionRequest.CreateBasicProperties();
            propsConnectionRequest.Persistent = true;

            channelConnectionRequestToTransportCompany = connection.CreateModel();
            channelConnectionRequestToTransportCompany.QueueDeclare(queue: GLOBAL.CONNECTION_REQUEST_WORKER_QUEUE,
                     durable: false,
                     exclusive: false,
                     autoDelete: false,
                     arguments: null);
            channelConnectionRequestToTransportCompany.ExchangeDeclare(exchange: GLOBAL.CONNECTION_REQUEST_TO_TRANSPORT_COMPANY_EXCHANGE, type: "direct");

            propsConnectionRequestToTransportCompany = channelConnectionRequestToTransportCompany.CreateBasicProperties();
            propsConnectionRequestToTransportCompany.CorrelationId = Guid.NewGuid().ToString();
            propsConnectionRequestToTransportCompany.ReplyTo = channelConnectionRequestToTransportCompany.QueueDeclare().QueueName;
            propsConnectionRequestToTransportCompany.Persistent = true;

            ListenToConnectionRequest();
        }

        private void ListenToConnectionRequest()
        {
            var consumer = new EventingBasicConsumer(channelConnectionRequest);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body;
                var message = Encoding.UTF8.GetString(body);

                Thread.Sleep(1000);

                Console.WriteLine("Received CONNECTION REQUEST: {0}", message);

                channelConnectionRequest.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);

                SendConnectionRequestToTransportCompany(message, ea.BasicProperties);
            };
            channelConnectionRequest.BasicConsume(queue: GLOBAL.CONNECTION_REQUEST_WORKER_QUEUE,
                                 autoAck: false,
                                 consumer: consumer);
        }

        private void SendConnectionRequestToTransportCompany(string connectionRequest, IBasicProperties props)
        {
            channelConnectionRequestToTransportCompany.BasicPublish(exchange: GLOBAL.CONNECTION_REQUEST_TO_TRANSPORT_COMPANY_EXCHANGE,
                                 routingKey: GLOBAL.TRANSPORT_DIRECT_ROUTING_KEY,
                                 basicProperties: props,
                                 body: Encoding.UTF8.GetBytes(connectionRequest));
        }
    }
}
