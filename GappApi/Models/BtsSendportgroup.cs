using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsSendportgroup
    {
        public BtsSendportgroup()
        {
            BtsOrchestrationPortBinding = new HashSet<BtsOrchestrationPortBinding>();
            BtsSpgSendport = new HashSet<BtsSpgSendport>();
        }

        public int NId { get; set; }
        public string NvcName { get; set; } = null!;
        public int NPortStatus { get; set; }
        public string NvcFilter { get; set; } = null!;
        public Guid UidGuid { get; set; }
        public string? NvcCustomData { get; set; }
        public DateTime DateModified { get; set; }
        public int NApplicationId { get; set; }
        public string? NvcDescription { get; set; }

        public virtual BtsApplication NApplication { get; set; } = null!;
        public virtual ICollection<BtsOrchestrationPortBinding> BtsOrchestrationPortBinding { get; set; }
        public virtual ICollection<BtsSpgSendport> BtsSpgSendport { get; set; }
    }
}
