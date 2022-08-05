using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class TicketClerk
    {
        public int ClerkId { get; set; }
        public string ClerkFirst { get; set; } = null!;
        public string ClerkLast { get; set; } = null!;
        public string ClerkMiddle { get; set; } = null!;
        public string ClerkAddress { get; set; } = null!;
        public string ClerkCity { get; set; } = null!;
        public string ClerkState { get; set; } = null!;
        public string ClerkZip { get; set; } = null!;
        public int ClerkAirport { get; set; }

        public virtual Airport ClerkAirportNavigation { get; set; } = null!;
    }
}
