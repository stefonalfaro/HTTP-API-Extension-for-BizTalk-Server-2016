using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsEnlistedpartyPortMapping
    {
        public BtsEnlistedpartyPortMapping()
        {
            BtsEnlistedpartyOperationMapping = new HashSet<BtsEnlistedpartyOperationMapping>();
        }

        public int NId { get; set; }
        public int NRolePortTypeId { get; set; }
        public int NEnlistedPartyId { get; set; }
        public DateTime DateModified { get; set; }

        public virtual BtsEnlistedparty NEnlistedParty { get; set; } = null!;
        public virtual BtsRolePorttype NRolePortType { get; set; } = null!;
        public virtual ICollection<BtsEnlistedpartyOperationMapping> BtsEnlistedpartyOperationMapping { get; set; }
    }
}
