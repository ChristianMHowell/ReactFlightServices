using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class PassengerTicket
    {
        public int PassengerTicketId { get; set; }
        public int TicketId { get; set; }
        public int PassengerId { get; set; }
        public bool Boarded { get; set; }

        public virtual Passenger Passenger { get; set; } = null!;
        public virtual Ticket Ticket { get; set; } = null!;
    }
}
