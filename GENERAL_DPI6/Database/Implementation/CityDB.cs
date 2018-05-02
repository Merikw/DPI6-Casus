using GENERAL_DPI6.Database.Interface_repo_s;
using GENERAL_DPI6.Models.DB_Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERAL_DPI6.Database.Implementation
{
    public class CityDB : ICityDB
    {
        private readonly IMongoDB MongoDB;

        public CityDB()
        {
            MongoDB = new MongoDB();
        }

        public async Task<List<CityDBModel>> GetAll()
        {
            var collection = MongoDB.GetDatabase().GetCollection<CityDBModel>(MongoDB.GetCollectionCity());
            var filter = FilterDefinition<CityDBModel>.Empty;
            var result = await collection.FindAsync(filter);
            return await result.ToListAsync();
        }

        public void Insert(CityDBModel obj)
        {
            var collection = MongoDB.GetDatabase().GetCollection<CityDBModel>(MongoDB.GetCollectionCity());
            collection.InsertOne(obj);
        }
    }
}
