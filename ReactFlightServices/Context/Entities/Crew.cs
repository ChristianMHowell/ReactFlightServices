using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class Crew
    {
        public int CrewId { get; set; }
        public string CrewFirst { get; set; } = null!;
        public string CrewLast { get; set; } = null!;
        public string CrewMiddle { get; set; } = null!;
        public string CrewAddress { get; set; } = null!;
        public string CrewCity { get; set; } = null!;
        public string CrewState { get; set; } = null!;
        public string CrewZip { get; set; } = null!;
        public string CrewEmail { get; set; } = null!;
        public string CrewPhone { get; set; } = null!;
    }
}
