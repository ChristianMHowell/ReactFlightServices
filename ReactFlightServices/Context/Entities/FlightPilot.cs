using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class FlightPilot
    {
        public int PilotFlightId { get; set; }
        public int PilotId { get; set; }
        public int FlightId { get; set; }

        public virtual Flight Flight { get; set; } = null!;
        public virtual Pilot Pilot { get; set; } = null!;
    }
}
