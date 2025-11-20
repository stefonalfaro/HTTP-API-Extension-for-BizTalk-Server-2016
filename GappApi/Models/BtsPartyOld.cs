using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsPartyOld
    {
        public int NId { get; set; }
        public string NvcName { get; set; } = null!;
        public string? NvcSignatureCert { get; set; }
        public string? NvcSignatureCertHash { get; set; }
        public string NvcSid { get; set; } = null!;
        public string? NvcCustomData { get; set; }
        public DateTime DateModified { get; set; }
    }
}
