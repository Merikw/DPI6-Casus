using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERAL_DPI6.Database.Interface_repo_s
{
    public interface IMongoDB
    {
        IMongoDatabase GetDatabase();
        string GetCollectionTransportCompany();
        string GetCollectionCity();
    }
}
