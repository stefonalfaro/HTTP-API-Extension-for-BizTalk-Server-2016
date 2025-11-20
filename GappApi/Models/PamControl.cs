using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class PamControl
    {
        public short EdiMessageType { get; set; }
        public string ActionType { get; set; } = null!;
        public DateTime? ActionDateTime { get; set; }
        public bool UsedOnce { get; set; }
        public long BatchId { get; set; }
        public string BatchName { get; set; } = null!;
        public string SenderPartyName { get; set; } = null!;
        public string ReceiverPartyName { get; set; } = null!;
        public string AgreementName { get; set; } = null!;

        public virtual BatchDescription Batch { get; set; } = null!;
    }
}
