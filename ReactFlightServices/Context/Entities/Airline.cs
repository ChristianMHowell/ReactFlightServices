using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class Airline
    {
        public Airline()
        {
            CrewAirlines = new HashSet<CrewAirline>();
            Flights = new HashSet<Flight>();
        }

        public int AirlineId { get; set; }
        public string AirlineName { get; set; } = null!;
        public string AirlineCity { get; set; } = null!;
        public string AirlineAddress { get; set; } = null!;

        public virtual ICollection<CrewAirline> CrewAirlines { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
    }
}
