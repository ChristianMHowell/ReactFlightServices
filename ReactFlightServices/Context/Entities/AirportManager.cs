using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class AirportManager
    {
        public int ManagerId { get; set; }
        public string ManagerFirst { get; set; } = null!;
        public string ManagerLast { get; set; } = null!;
        public string? ManagerMiddle { get; set; }
        public string ManagerAddress { get; set; } = null!;
        public string ManagerCity { get; set; } = null!;
        public string ManagerState { get; set; } = null!;
        public string ManagerZip { get; set; } = null!;
        public int ManagerAirport { get; set; }

        public virtual Airport ManagerAirportNavigation { get; set; } = null!;
    }
}
