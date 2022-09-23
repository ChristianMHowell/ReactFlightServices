using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class TicektPayment
    {
        public int TicketPaymentId { get; set; }
        public int TicketId { get; set; }
        public int PaymentId { get; set; }
        public bool? Refund { get; set; }
    }
}
