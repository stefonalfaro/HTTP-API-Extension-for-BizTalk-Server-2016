using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsMessagetype
    {
        public BtsMessagetype()
        {
            BtsMessagetypePart = new HashSet<BtsMessagetypePart>();
        }

        public int NId { get; set; }
        public int NAssemblyId { get; set; }
        public string? NvcNamespace { get; set; }
        public string NvcName { get; set; } = null!;
        public string? NvcFullName { get; set; }

        public virtual ICollection<BtsMessagetypePart> BtsMessagetypePart { get; set; }
    }
}
