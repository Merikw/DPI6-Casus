using GENERAL_DPI6.Database;
using GENERAL_DPI6.Database.Implementation;
using GENERAL_DPI6.Enums;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERAL_DPI6.Models.DB_Models
{
    public class TransportCompanyDBModel
    {
        [BsonId]
        public Guid Id { get; set; }
        [BsonElement]
        public string Name { get; set; }
        [BsonElement]
        public TRANSPORT_TYPE TransportType { get; set; }
        
        public TransportCompanyDBModel()
        {

        }

        public TransportCompanyDBModel(string name, TRANSPORT_TYPE transportType)
        {
            Name = name;
            TransportType = transportType;
        }
    }
}
