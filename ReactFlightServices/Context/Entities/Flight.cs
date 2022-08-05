using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class Flight
    {
        public Flight()
        {
            FlightGates = new HashSet<FlightGate>();
            Tickets = new HashSet<Ticket>();
        }

        public int FlightId { get; set; }
        public string FlightName { get; set; } = null!;
        public TimeSpan FlightTIme { get; set; }
        public int FlightOrigin { get; set; }
        public int FlightEnd { get; set; }
        public bool FlightStopover { get; set; }
        public int FlightAirline { get; set; }
        public int FLightRecurrence { get; set; }
        public int FlightDistance { get; set; }
        public double FlightDuration { get; set; }
        public int FlightCapacity { get; set; }
        public int StopoverLocation { get; set; }
        public DateTime FlightDate { get; set; }

        public virtual ICollection<FlightGate> FlightGates { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
