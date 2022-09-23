using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class Ticket
    {
        public Ticket()
        {
            PassengerTickets = new HashSet<PassengerTicket>();
            TicketClerkTickets = new HashSet<TicketClerkTicket>();
            TicketPayments = new HashSet<TicketPayment>();
        }

        public int TicketId { get; set; }
        public string TicketNumber { get; set; } = null!;
        public decimal TicketPrice { get; set; }
        public int TicketFlight { get; set; }
        public DateTime TicketDate { get; set; }
        public int TicketRow { get; set; }
        public string TicketSeat { get; set; } = null!;

        public virtual Flight TicketFlightNavigation { get; set; } = null!;
        public virtual ICollection<PassengerTicket> PassengerTickets { get; set; }
        public virtual ICollection<TicketClerkTicket> TicketClerkTickets { get; set; }
        public virtual ICollection<TicketPayment> TicketPayments { get; set; }
    }
}
