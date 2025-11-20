using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BamTrackingProfiles
    {
        public string NvcName { get; set; } = null!;
        public Guid UidVersionId { get; set; }
        public int NMinorVersionId { get; set; }
        public int NId { get; set; }
    }
}
