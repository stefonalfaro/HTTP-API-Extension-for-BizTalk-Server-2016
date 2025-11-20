using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class Partner
    {
        public Partner()
        {
            BtsEnlistedparty = new HashSet<BtsEnlistedparty>();
            BusinessProfile = new HashSet<BusinessProfile>();
            PartnershipPartnerA = new HashSet<Partnership>();
            PartnershipPartnerB = new HashSet<Partnership>();
            SendPortReference = new HashSet<SendPortReference>();
        }

        public int PartnerId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? Sid { get; set; }
        public string? CertificateName { get; set; }
        public string? CertificateHash { get; set; }
        public int? CustomSettingsId { get; set; }
        public DateTime DateModified { get; set; }
        public string? CustomData { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual ICollection<BtsEnlistedparty> BtsEnlistedparty { get; set; }
        public virtual ICollection<BusinessProfile> BusinessProfile { get; set; }
        public virtual ICollection<Partnership> PartnershipPartnerA { get; set; }
        public virtual ICollection<Partnership> PartnershipPartnerB { get; set; }
        public virtual ICollection<SendPortReference> SendPortReference { get; set; }
    }
}
