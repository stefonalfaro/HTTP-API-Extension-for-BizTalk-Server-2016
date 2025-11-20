using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsRolePorttype
    {
        public BtsRolePorttype()
        {
            BtsEnlistedpartyPortMapping = new HashSet<BtsEnlistedpartyPortMapping>();
        }

        public int NId { get; set; }
        public int NRoleId { get; set; }
        public int NPortTypeId { get; set; }

        public virtual BtsPorttype NPortType { get; set; } = null!;
        public virtual BtsRole NRole { get; set; } = null!;
        public virtual ICollection<BtsEnlistedpartyPortMapping> BtsEnlistedpartyPortMapping { get; set; }
    }
}
