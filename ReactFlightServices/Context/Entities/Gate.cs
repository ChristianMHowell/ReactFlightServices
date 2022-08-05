using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class Gate
    {
        public Gate()
        {
            FlightGates = new HashSet<FlightGate>();
        }

        public int GateId { get; set; }
        public int GateNumber { get; set; }
        public string GateTerminal { get; set; } = null!;

        public virtual ICollection<FlightGate> FlightGates { get; set; }
    }
}
