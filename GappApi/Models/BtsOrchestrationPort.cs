using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsOrchestrationPort
    {
        public BtsOrchestrationPort()
        {
            BtsOrchestrationPortBinding = new HashSet<BtsOrchestrationPortBinding>();
        }

        public int NId { get; set; }
        public Guid? UidGuid { get; set; }
        public int NOrchestrationId { get; set; }
        public int NPortTypeId { get; set; }
        public string NvcName { get; set; } = null!;
        public int NPolarity { get; set; }
        public int NBindingOption { get; set; }
        public int? NRolePortTypeId { get; set; }
        public bool BLink { get; set; }

        public virtual BtsOrchestration NOrchestration { get; set; } = null!;
        public virtual BtsPorttype NPortType { get; set; } = null!;
        public virtual ICollection<BtsOrchestrationPortBinding> BtsOrchestrationPortBinding { get; set; }
    }
}
