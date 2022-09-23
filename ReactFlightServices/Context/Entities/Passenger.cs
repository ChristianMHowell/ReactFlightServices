using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class Passenger
    {
        public Passenger()
        {
            PassengerTickets = new HashSet<PassengerTicket>();
            Payments = new HashSet<Payment>();
        }

        public int PassengerId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string ZipCode { get; set; } = null!;
        public byte[] PaymentAccount { get; set; } = null!;
        public string PaymentCode { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public bool HasRealId { get; set; }

        public virtual ICollection<PassengerTicket> PassengerTickets { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
