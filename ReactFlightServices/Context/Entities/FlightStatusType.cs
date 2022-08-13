using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class FlightStatusType
    {
        public FlightStatusType()
        {
            Flights = new HashSet<Flight>();
        }

        public int FlightStatusId { get; set; }
        public string StatusName { get; set; } = null!;

        public virtual ICollection<Flight> Flights { get; set; }
    }
}
