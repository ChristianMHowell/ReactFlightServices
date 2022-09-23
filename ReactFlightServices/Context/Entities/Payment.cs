using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class Payment
    {
        public Payment()
        {
            TicketPayments = new HashSet<TicketPayment>();
        }

        public int PaymentId { get; set; }
        public int PaymentPassenger { get; set; }
        public string PaymentType { get; set; } = null!;
        public string PaymentNumber { get; set; } = null!;
        public string PaymentCode { get; set; } = null!;
        public DateTime PaymentExpire { get; set; }

        public virtual Passenger PaymentPassengerNavigation { get; set; } = null!;
        public virtual ICollection<TicketPayment> TicketPayments { get; set; }
    }
}
