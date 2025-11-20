using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class ProtocolSettings
    {
        public ProtocolSettings()
        {
            AgreementReceiverProtocolSettings = new HashSet<Agreement>();
            AgreementSenderProtocolSettings = new HashSet<Agreement>();
            FallbackSettings = new HashSet<FallbackSettings>();
            OnewayAgreement = new HashSet<OnewayAgreement>();
        }

        public int ProtocolSettingsId { get; set; }
        public int? ProfileId { get; set; }
        public string ProtocolName { get; set; } = null!;
        public string SettingsName { get; set; } = null!;

        public virtual BusinessProfile? Profile { get; set; }
        public virtual As2protocolSettings? As2protocolSettings { get; set; }
        public virtual EdifactprotocolSettings? EdifactprotocolSettings { get; set; }
        public virtual TestSettings? TestSettings { get; set; }
        public virtual X12protocolSettings? X12protocolSettings { get; set; }
        public virtual ICollection<Agreement> AgreementReceiverProtocolSettings { get; set; }
        public virtual ICollection<Agreement> AgreementSenderProtocolSettings { get; set; }
        public virtual ICollection<FallbackSettings> FallbackSettings { get; set; }
        public virtual ICollection<OnewayAgreement> OnewayAgreement { get; set; }
    }
}
