using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class Agreement
    {
        public Agreement()
        {
            Contact = new HashSet<Contact>();
        }

        public int Id { get; set; }
        public int PartnershipId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool Enabled { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Protocol { get; set; } = null!;
        public int SenderProfileId { get; set; }
        public int? SenderProtocolSettingsId { get; set; }
        public int SenderOnewayAgreementId { get; set; }
        public int ReceiverProfileId { get; set; }
        public int? ReceiverProtocolSettingsId { get; set; }
        public int ReceiverOnewayAgreementId { get; set; }
        public int? CustomSettingsId { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual Partnership Partnership { get; set; } = null!;
        public virtual ProtocolSettings? ReceiverProtocolSettings { get; set; }
        public virtual ProtocolSettings? SenderProtocolSettings { get; set; }
        public virtual ICollection<Contact> Contact { get; set; }
    }
}
