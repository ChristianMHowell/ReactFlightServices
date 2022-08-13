using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class Pilot
    {
        public Pilot()
        {
            FlightPilots = new HashSet<FlightPilot>();
        }

        public int PilotId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string ZipCode { get; set; } = null!;
        public bool Captain { get; set; }
        public string PilotEmail { get; set; } = null!;

        public virtual ICollection<FlightPilot> FlightPilots { get; set; }
    }
}
