using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERAL_DPI6.Models
{
    public class RequestReply<REQUEST, REPLY>
    {
        public REQUEST Request { get; set; }
        public REPLY Reply { get; set; }

        public RequestReply(REQUEST request, REPLY reply)
        {
            Request = request;
            Reply = reply;
        }
    }
}
