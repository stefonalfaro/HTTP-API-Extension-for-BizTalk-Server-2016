using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BusinessIdentity
    {
        public BusinessIdentity()
        {
            FallbackSettingsReceiver = new HashSet<FallbackSettings>();
            FallbackSettingsSender = new HashSet<FallbackSettings>();
            OnewayAgreementReceiver = new HashSet<OnewayAgreement>();
            OnewayAgreementSender = new HashSet<OnewayAgreement>();
        }

        public int Id { get; set; }
        public int? ProfileId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string Qualifier { get; set; } = null!;
        public string Value { get; set; } = null!;
        public string? AdditionalData { get; set; }
        public DateTime DateModified { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual BusinessProfile? Profile { get; set; }
        public virtual ICollection<FallbackSettings> FallbackSettingsReceiver { get; set; }
        public virtual ICollection<FallbackSettings> FallbackSettingsSender { get; set; }
        public virtual ICollection<OnewayAgreement> OnewayAgreementReceiver { get; set; }
        public virtual ICollection<OnewayAgreement> OnewayAgreementSender { get; set; }
    }
}
