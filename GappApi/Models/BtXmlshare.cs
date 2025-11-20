using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtXmlshare
    {
        public BtXmlshare()
        {
            BtMapSpec = new HashSet<BtMapSpec>();
        }

        public Guid Id { get; set; }
        public byte Active { get; set; }
        public string? TargetNamespace { get; set; }
        public DateTime? DateModified { get; set; }
        public string? Content { get; set; }

        public virtual ICollection<BtMapSpec> BtMapSpec { get; set; }
    }
}
