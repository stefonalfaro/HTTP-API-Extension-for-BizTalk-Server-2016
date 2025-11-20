using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsRolelink
    {
        public int NId { get; set; }
        public string NvcName { get; set; } = null!;
        public string? NvcFullName { get; set; }
        public int NOrchestrationId { get; set; }
        public int NRoleId { get; set; }
        public bool BImplements { get; set; }
        public int NBindingType { get; set; }

        public virtual BtsOrchestration NOrchestration { get; set; } = null!;
        public virtual BtsRole NRole { get; set; } = null!;
    }
}
