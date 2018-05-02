using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GENERAL_DPI6.Database.Interface_repo_s;
using GENERAL_DPI6.JMS;
using GENERAL_DPI6.Models.DB_Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace GENERAL_DPI6.Database.Implementation
{
    public class TransportCompanyDB : ITransportCompanyDB
    {
        private readonly IMongoDB MongoDB;

        public TransportCompanyDB()
        {
            MongoDB = new MongoDB();
        }

        public async Task<TransportCompanyDBModel> FindByName(string name)
        {
            var collection = MongoDB.GetDatabase().GetCollection<TransportCompanyDBModel>(MongoDB.GetCollectionTransportCompany());
            var foundTransportCompany = await (await collection.FindAsync(x => x.Name == name)).SingleOrDefaultAsync();
            return foundTransportCompany;
        }

        public Task<List<TransportCompanyDBModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(TransportCompanyDBModel obj)
        {
            var collection = MongoDB.GetDatabase().GetCollection<TransportCompanyDBModel>(MongoDB.GetCollectionTransportCompany());
            collection.InsertOne(obj);
        }
    }
}
