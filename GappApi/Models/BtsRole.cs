using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsRole
    {
        public BtsRole()
        {
            BtsEnlistedparty = new HashSet<BtsEnlistedparty>();
            BtsRolePorttype = new HashSet<BtsRolePorttype>();
            BtsRolelink = new HashSet<BtsRolelink>();
        }

        public int NId { get; set; }
        public string NvcName { get; set; } = null!;
        public string? NvcFullName { get; set; }
        public int NRoleLinkTypeId { get; set; }

        public virtual BtsRolelinkType NRoleLinkType { get; set; } = null!;
        public virtual ICollection<BtsEnlistedparty> BtsEnlistedparty { get; set; }
        public virtual ICollection<BtsRolePorttype> BtsRolePorttype { get; set; }
        public virtual ICollection<BtsRolelink> BtsRolelink { get; set; }
    }
}
