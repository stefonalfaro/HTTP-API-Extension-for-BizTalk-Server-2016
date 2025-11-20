using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsPartyAlias
    {
        public int? NId { get; set; }
        public int NPartyId { get; set; }
        public string? NvcName { get; set; }
        public string NvcQualifier { get; set; } = null!;
        public string NvcValue { get; set; } = null!;
        public DateTime? DateModified { get; set; }
    }
}
