using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class CrewAirline
    {
        public int AirlineCrewId { get; set; }
        public int AirlineId { get; set; }
        public int CrewId { get; set; }

        public virtual Airline Airline { get; set; } = null!;
        public virtual Crew Crew { get; set; } = null!;
    }
}
