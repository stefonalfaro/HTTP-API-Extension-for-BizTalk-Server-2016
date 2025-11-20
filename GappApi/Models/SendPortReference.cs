using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class SendPortReference
    {
        public SendPortReference()
        {
            BtsEnlistedpartyOperationMapping = new HashSet<BtsEnlistedpartyOperationMapping>();
            OnewayAgreement = new HashSet<OnewayAgreement>();
        }

        public int Id { get; set; }
        public int PartnerId { get; set; }
        public string Name { get; set; } = null!;
        public int SequenceNumber { get; set; }
        public DateTime DateModified { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual BtsSendport NameNavigation { get; set; } = null!;
        public virtual Partner Partner { get; set; } = null!;
        public virtual ICollection<BtsEnlistedpartyOperationMapping> BtsEnlistedpartyOperationMapping { get; set; }

        public virtual ICollection<OnewayAgreement> OnewayAgreement { get; set; }
    }
}
