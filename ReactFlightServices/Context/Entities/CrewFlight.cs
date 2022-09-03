using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class CrewFlight
    {
        public int CrewFilghtId { get; set; }
        public int FlightId { get; set; }
        public int CrewId { get; set; }

        public virtual Crew Crew { get; set; } = null!;
        public virtual Flight Flight { get; set; } = null!;
    }
}
