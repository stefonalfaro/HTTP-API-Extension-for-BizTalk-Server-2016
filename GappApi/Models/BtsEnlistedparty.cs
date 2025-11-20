using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsEnlistedparty
    {
        public BtsEnlistedparty()
        {
            BtsEnlistedpartyPortMapping = new HashSet<BtsEnlistedpartyPortMapping>();
        }

        public int NId { get; set; }
        public int NRoleId { get; set; }
        public int NPartyId { get; set; }
        public DateTime DateModified { get; set; }

        public virtual Partner NParty { get; set; } = null!;
        public virtual BtsRole NRole { get; set; } = null!;
        public virtual ICollection<BtsEnlistedpartyPortMapping> BtsEnlistedpartyPortMapping { get; set; }
    }
}
