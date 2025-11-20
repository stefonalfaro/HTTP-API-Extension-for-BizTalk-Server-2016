using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class OnewayAgreement
    {
        public OnewayAgreement()
        {
            AgreementAlias = new HashSet<AgreementAlias>();
            BatchDescription = new HashSet<BatchDescription>();
            SendPortReference = new HashSet<SendPortReference>();
        }

        public int Id { get; set; }
        public int ProtocolSettingsId { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual ProtocolSettings ProtocolSettings { get; set; } = null!;
        public virtual BusinessIdentity Receiver { get; set; } = null!;
        public virtual BusinessIdentity Sender { get; set; } = null!;
        public virtual ICollection<AgreementAlias> AgreementAlias { get; set; }
        public virtual ICollection<BatchDescription> BatchDescription { get; set; }

        public virtual ICollection<SendPortReference> SendPortReference { get; set; }
    }
}
