using GENERAL_DPI6.Database;
using GENERAL_DPI6.Database.Implementation;
using GENERAL_DPI6.Enums;
using GENERAL_DPI6.Global;
using GENERAL_DPI6.Models.DB_Models;
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
    public class TransportCompany
    {
        private TransportCompanyDBModel transportCompanyDBModel;

        private string transportCompanyName;
        private TRANSPORT_TYPE TransportType;

        private readonly IConnection connection;

        private IBasicProperties propsReceiveConnectionRequest;
        private readonly IModel channelReceiveConnectionRequest;
        private string queueNameReceiveConnectionRequest;

        private ITransportCompanyDB TransportCompanyDB;

        public TransportCompany(string name, TRANSPORT_TYPE transportType)
        {
            transportCompanyName = name;
            TransportType = transportType;

            //ConnectionFactory connectionFactory = new ConnectionFactory();
            //connectionFactory.HostName = GLOBAL.HOST_NAME;
            //connectionFactory.Port = GLOBAL.PORT;

            //connection = connectionFactory.CreateConnection();

            //channelReceiveConnectionRequest = connection.CreateModel();

            //channelReceiveConnectionRequest.ExchangeDeclare(exchange: GLOBAL.CONNECTION_REQUEST_TO_TRANSPORT_COMPANY_EXCHANGE, type: "direct");

            //queueNameReceiveConnectionRequest = channelReceiveConnectionRequest.QueueDeclare().QueueName;

            //channelReceiveConnectionRequest.QueueBind(queue: queueNameReceiveConnectionRequest,
            //                      exchange: GLOBAL.CONNECTION_REQUEST_TO_TRANSPORT_COMPANY_EXCHANGE,
            //                      routingKey: GLOBAL.TRANSPORT_DIRECT_ROUTING_KEY);

            TransportCompanyDB = new TransportCompanyDB();

            AddNewOrExistingTransportCompanyAsync(); 
            //ListenToConnectionRequest();
        }

        private async Task AddNewOrExistingTransportCompanyAsync()
        {
            TransportCompanyDBModel createdTransportCompany = new TransportCompanyDBModel();
            TransportCompanyDBModel foundTransportCompany = await TransportCompanyDB.FindByName(transportCompanyName);
            if(foundTransportCompany == null)
            {
                createdTransportCompany = new TransportCompanyDBModel(transportCompanyName, TransportType, new List<ConnectionDBModel>());
                TransportCompanyDB.Insert(createdTransportCompany);
            } else
            {
                createdTransportCompany = foundTransportCompany;
            }
            transportCompanyDBModel = createdTransportCompany;
        }

        private void ListenToConnectionRequest()
        {
            var consumer = new EventingBasicConsumer(channelReceiveConnectionRequest);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body;
                var message = Encoding.UTF8.GetString(body);
                var routingKey = ea.RoutingKey;
            };
            channelReceiveConnectionRequest.BasicConsume(queue: queueNameReceiveConnectionRequest,
                                 autoAck: true,
                                 consumer: consumer);
        }

        public TransportCompanyDBModel getTransportCompanyDBModel()
        {
            if(transportCompanyDBModel != null)
            {
                return transportCompanyDBModel;
            } else
            {
                Thread.Sleep(300);
                return getTransportCompanyDBModel();
            }
        }

        public void AddConnection(ConnectionDBModel connection)
        {
            transportCompanyDBModel.addConnection(connection);

        }
    }
}
