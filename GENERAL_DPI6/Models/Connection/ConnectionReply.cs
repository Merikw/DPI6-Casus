using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GENERAL_DPI6.Enums;

namespace GENERAL_DPI6.Models.Connection
{
    public class ConnectionReply
    {
        public Guid ConnectionId { get; set; }
        public Double Price { get; set; }
        public Double CO2Emission { get; set; }
        public Double Duration{ get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Company { get; set; }
        public TRANSPORT_TYPE TransportType { get; set; }
        public int SeatsAvailable { get; set; }

        public ConnectionReply(Guid connectionId, Double price, Double co2Emission, Double duration, DateTime date, DateTime time, string company, TRANSPORT_TYPE transportType, int seatsAvailable)
        {
            ConnectionId = connectionId;
            Price = price;
            CO2Emission = co2Emission;
            Duration = duration;
            Date = date;
            Time = time;
            Company = company;
            TransportType = transportType;
            SeatsAvailable = seatsAvailable;
        }
    }
}
