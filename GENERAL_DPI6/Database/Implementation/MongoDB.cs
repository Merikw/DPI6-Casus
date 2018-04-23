using GENERAL_DPI6.Database.Interface_repo_s;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERAL_DPI6.Database
{
    public class MongoDB : IMongoDB
    {
        private IMongoDatabase database;
        private readonly static string DATABASENAME = "bp72o7kue5mqfnr";
        private readonly static string COLLECTIONTRANSPORTCOMPANY = "TransportCompany";
        private readonly static string CONNECTIONSTRING = "mongodb://u4lf0yut74ulhc2:kg5YkBWrgX5KKxPQNP6V@bp72o7kue5mqfnr-mongodb.services.clever-cloud.com:27017/bp72o7kue5mqfnr";

        public MongoDB()
        {
            database = new MongoClient(CONNECTIONSTRING).GetDatabase(DATABASENAME);
        }

        public IMongoDatabase GetDatabase()
        {
            return database;
        }

        public string GetCollectionTransportCompany()
        {
            return COLLECTIONTRANSPORTCOMPANY;
        }
    }
}