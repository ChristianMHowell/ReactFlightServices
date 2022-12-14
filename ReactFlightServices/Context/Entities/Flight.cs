using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class Flight
    {
        public Flight()
        {
            CrewFlights = new HashSet<CrewFlight>();
            FlightGates = new HashSet<FlightGate>();
            FlightPilots = new HashSet<FlightPilot>();
            Tickets = new HashSet<Ticket>();
        }

        public int FlightId { get; set; }
        public string FlightName { get; set; } = null!;
        public TimeSpan FlightTIme { get; set; }
        public int FlightOrigin { get; set; }
        public int FlightEnd { get; set; }
        public int FlightAirline { get; set; }
        public int FLightRecurrence { get; set; }
        public double FlightDistance { get; set; }
        public double FlightDuration { get; set; }
        public int? StopoverLocation { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightStatus { get; set; }
        public int FlightRows { get; set; }
        public int FlightSeats { get; set; }

        public virtual Airline FlightAirlineNavigation { get; set; } = null!;
        public virtual FlightStatusType FlightStatusNavigation { get; set; } = null!;
        public virtual ICollection<CrewFlight> CrewFlights { get; set; }
        public virtual ICollection<FlightGate> FlightGates { get; set; }
        public virtual ICollection<FlightPilot> FlightPilots { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
