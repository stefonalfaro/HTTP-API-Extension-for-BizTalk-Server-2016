using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BusinessProfile
    {
        public BusinessProfile()
        {
            BusinessIdentity = new HashSet<BusinessIdentity>();
            ProtocolSettings = new HashSet<ProtocolSettings>();
        }

        public int ProfileId { get; set; }
        public int PartnerId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int? CustomSettingsId { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual Partner Partner { get; set; } = null!;
        public virtual ICollection<BusinessIdentity> BusinessIdentity { get; set; }
        public virtual ICollection<ProtocolSettings> ProtocolSettings { get; set; }
    }
}
