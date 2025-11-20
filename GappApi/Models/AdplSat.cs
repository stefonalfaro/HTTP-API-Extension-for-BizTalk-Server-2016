using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class AdplSat
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public string? SdmType { get; set; }
        public string? Luid { get; set; }
        public string? Properties { get; set; }
        public string? Files { get; set; }
        public byte[]? CabContent { get; set; }

        public virtual BtsApplication Application { get; set; } = null!;
    }
}
