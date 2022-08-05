using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class FlightGate
    {
        public int FlightGateId { get; set; }
        public int FlightId { get; set; }
        public int GateId { get; set; }

        public virtual Flight Flight { get; set; } = null!;
        public virtual Gate Gate { get; set; } = null!;
    }
}
