using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class Airport
    {
        public Airport()
        {
            AirportManagers = new HashSet<AirportManager>();
            Terminals = new HashSet<Terminal>();
            TicketClerks = new HashSet<TicketClerk>();
        }

        public int AirportId { get; set; }
        public string AirportName { get; set; } = null!;
        public string AirportCity { get; set; } = null!;
        public int SquareFeet { get; set; }
        public bool International { get; set; }
        public TimeSpan TimeOpen { get; set; }
        public TimeSpan TimeClose { get; set; }
        public int TerminalCount { get; set; }
        public int VendorCount { get; set; }

        public virtual ICollection<AirportManager> AirportManagers { get; set; }
        public virtual ICollection<Terminal> Terminals { get; set; }
        public virtual ICollection<TicketClerk> TicketClerks { get; set; }
    }
}
