using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERAL_DPI6.Models.DB_Models
{
    public class CityDBModel
    {
        [BsonId]
        public Guid Id { get; set; }
        [BsonElement]
        public string Name { get; set; }

        public CityDBModel()
        {

        }

        public CityDBModel(string name)
        {
            Name = name;
        }
    }
}
