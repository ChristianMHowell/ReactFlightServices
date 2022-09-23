using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class TicketPayment
    {
        public int TicketPaymentId { get; set; }
        public int TicketId { get; set; }
        public int PaymentId { get; set; }
        public bool? Refund { get; set; }

        public virtual Payment Payment { get; set; } = null!;
        public virtual Ticket Ticket { get; set; } = null!;
    }
}
