using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsParty
    {
        public int NId { get; set; }
        public string NvcName { get; set; } = null!;
        public string? NvcSid { get; set; }
        public string? NvcSignatureCert { get; set; }
        public string? NvcSignatureCertHash { get; set; }
        public DateTime DateModified { get; set; }
        public string? NvcCustomData { get; set; }
    }
}
