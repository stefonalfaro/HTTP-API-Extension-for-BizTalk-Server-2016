using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsPorttype
    {
        public BtsPorttype()
        {
            BtsOrchestrationPort = new HashSet<BtsOrchestrationPort>();
            BtsPorttypeOperation = new HashSet<BtsPorttypeOperation>();
            BtsRolePorttype = new HashSet<BtsRolePorttype>();
        }

        public int NId { get; set; }
        public int NAssemblyId { get; set; }
        public string? NvcNamespace { get; set; }
        public string NvcName { get; set; } = null!;
        public string? NvcFullName { get; set; }

        public virtual ICollection<BtsOrchestrationPort> BtsOrchestrationPort { get; set; }
        public virtual ICollection<BtsPorttypeOperation> BtsPorttypeOperation { get; set; }
        public virtual ICollection<BtsRolePorttype> BtsRolePorttype { get; set; }
    }
}
