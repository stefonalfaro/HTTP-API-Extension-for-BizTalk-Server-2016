using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class Partnership
    {
        public Partnership()
        {
            Agreement = new HashSet<Agreement>();
        }

        public int PartnershipId { get; set; }
        public int PartnerAid { get; set; }
        public int PartnerBid { get; set; }

        public virtual Partner PartnerA { get; set; } = null!;
        public virtual Partner PartnerB { get; set; } = null!;
        public virtual ICollection<Agreement> Agreement { get; set; }
    }
}
