using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsOrchestration
    {
        public BtsOrchestration()
        {
            BtsOrchestrationInvocation = new HashSet<BtsOrchestrationInvocation>();
            BtsOrchestrationPort = new HashSet<BtsOrchestrationPort>();
            BtsPortActivationOperation = new HashSet<BtsPortActivationOperation>();
            BtsRolelink = new HashSet<BtsRolelink>();
        }

        public int NId { get; set; }
        public Guid? UidGuid { get; set; }
        public Guid? UidOrchestrationType { get; set; }
        public int NAssemblyId { get; set; }
        public int? NItemId { get; set; }
        public string? NvcNamespace { get; set; }
        public string NvcName { get; set; } = null!;
        public string? NvcFullName { get; set; }
        public int NOrchestrationInfo { get; set; }
        public int NOrchestrationStatus { get; set; }
        public int? NAdminHostId { get; set; }
        public DateTime DtModified { get; set; }
        public string? NvcDescription { get; set; }

        public virtual BtsItem? NItem { get; set; }
        public virtual ICollection<BtsOrchestrationInvocation> BtsOrchestrationInvocation { get; set; }
        public virtual ICollection<BtsOrchestrationPort> BtsOrchestrationPort { get; set; }
        public virtual ICollection<BtsPortActivationOperation> BtsPortActivationOperation { get; set; }
        public virtual ICollection<BtsRolelink> BtsRolelink { get; set; }
    }
}
