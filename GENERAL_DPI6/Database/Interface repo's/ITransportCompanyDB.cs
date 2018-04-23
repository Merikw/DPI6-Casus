using GENERAL_DPI6.Database.Implementation;
using GENERAL_DPI6.Database.Interface_repo_s;
using GENERAL_DPI6.JMS;
using GENERAL_DPI6.Models.DB_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERAL_DPI6.Database
{
    public interface ITransportCompanyDB : IGenericDB<TransportCompanyDBModel>
    {
        Task<TransportCompanyDBModel> FindByName(string name);
    }
}
