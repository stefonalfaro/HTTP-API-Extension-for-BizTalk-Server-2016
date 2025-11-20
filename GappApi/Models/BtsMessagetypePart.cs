using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsMessagetypePart
    {
        public int NId { get; set; }
        public int NMessageTypeId { get; set; }
        public string? NvcNamespace { get; set; }
        public string NvcName { get; set; } = null!;
        public string? NvcFullName { get; set; }
        public string? NvcSchemaUrtnameSpace { get; set; }
        public string? NvcSchemaUrttypeName { get; set; }

        public virtual BtsMessagetype NMessageType { get; set; } = null!;
    }
}
