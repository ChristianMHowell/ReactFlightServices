using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class Terminal
    {
        public Terminal()
        {
            Vendors = new HashSet<Vendor>();
        }

        public int TerminalId { get; set; }
        public string TerminalName { get; set; } = null!;
        public int AirportId { get; set; }
        public string TerminalDesc { get; set; } = null!;
        public bool TerminalOpen { get; set; }
        public int GateCount { get; set; }

        public virtual Airport Airport { get; set; } = null!;
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
