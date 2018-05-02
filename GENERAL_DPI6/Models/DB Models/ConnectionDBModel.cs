using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERAL_DPI6.Models.DB_Models
{
    public class ConnectionDBModel
    {
        [BsonId]
        public Guid Id { get; set; }
        [BsonElement]
        public string CityFrom { get; set; }
        [BsonElement]
        public string CityTo { get; set; }
        [BsonElement]
        public int AvailableTickets { get; set; }
        [BsonElement]
        public int Price { get; set; }

        public ConnectionDBModel()
        {

        }

        public ConnectionDBModel(string cityFrom, string cityTo, int availableTickets, int price)
        {
            CityFrom = cityFrom;
            CityTo = cityTo;
            AvailableTickets = availableTickets;
            Price = price;
        }
    }
}
