using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class Airline
    {
        public Airline()
        {
            Flights = new HashSet<Flight>();
        }

        public int AirlineId { get; set; }
        public string AirlineName { get; set; } = null!;

        public virtual ICollection<Flight> Flights { get; set; }
    }
}
