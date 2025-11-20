using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsPorttypeOperation
    {
        public BtsPorttypeOperation()
        {
            BtsEnlistedpartyOperationMapping = new HashSet<BtsEnlistedpartyOperationMapping>();
            BtsOperationMsgtype = new HashSet<BtsOperationMsgtype>();
            BtsPortActivationOperation = new HashSet<BtsPortActivationOperation>();
        }

        public int NId { get; set; }
        public int NPortTypeId { get; set; }
        public string NvcName { get; set; } = null!;
        public string? NvcFullName { get; set; }
        public int NType { get; set; }

        public virtual BtsPorttype NPortType { get; set; } = null!;
        public virtual ICollection<BtsEnlistedpartyOperationMapping> BtsEnlistedpartyOperationMapping { get; set; }
        public virtual ICollection<BtsOperationMsgtype> BtsOperationMsgtype { get; set; }
        public virtual ICollection<BtsPortActivationOperation> BtsPortActivationOperation { get; set; }
    }
}
