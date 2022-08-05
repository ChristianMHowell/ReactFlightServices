using System;
using System.Collections.Generic;

namespace ReactFlightServices.Context.Entities
{
    public partial class Vendor
    {
        public int VendorId { get; set; }
        public string VendorName { get; set; } = null!;
        public string VendorDesc { get; set; } = null!;
        public int TerminalId { get; set; }

        public virtual Terminal Terminal { get; set; } = null!;
    }
}
