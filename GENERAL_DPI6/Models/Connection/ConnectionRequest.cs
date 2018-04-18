using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERAL_DPI6.Models.Connection
{
    [Serializable()]
    public class ConnectionRequest
    {
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string CityFrom { get; set; }
        public string CityTo { get; set; }

        public ConnectionRequest()
        {

        }

        public ConnectionRequest(DateTime date, DateTime time, string cityFrom, string cityTo)
        {
            Date = date;
            Time = time;
            CityFrom = cityFrom;
            CityTo = cityTo;
        }
    }
}
