using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class TicketClerkTicket
    {
        public int ClerkTicketsId { get; set; }
        public int TicketId { get; set; }
        public int ClerkId { get; set; }

        public virtual Ticket Ticket { get; set; } = null!;
    }
}
