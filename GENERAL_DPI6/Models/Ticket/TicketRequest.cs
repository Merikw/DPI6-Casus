using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERAL_DPI6.Models.Ticket
{
    public class TicketRequest
    {
        public Guid ForConnectionId { get; set; }
        public int Amount { get; set; }

        public TicketRequest(Guid forConnectionId, int amount)
        {
            ForConnectionId = forConnectionId;
            Amount = amount;
        }
    }
}
