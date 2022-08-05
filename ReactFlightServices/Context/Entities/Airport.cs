using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class Airport
    {
        public Airport()
        {
            Terminals = new HashSet<Terminal>();
            TicketClerks = new HashSet<TicketClerk>();
        }

        public int AirportId { get; set; }
        public string AirportName { get; set; } = null!;
        public string AirportCity { get; set; } = null!;

        public virtual ICollection<Terminal> Terminals { get; set; }
        public virtual ICollection<TicketClerk> TicketClerks { get; set; }
    }
}
