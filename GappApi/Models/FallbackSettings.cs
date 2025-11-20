using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class FallbackSettings
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public int ProtocolSettingsId { get; set; }
        public string ProtocolName { get; set; } = null!;
        public bool Enabled { get; set; }
        public int? CustomSettingsId { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual ProtocolSettings ProtocolSettings { get; set; } = null!;
        public virtual BusinessIdentity Receiver { get; set; } = null!;
        public virtual BusinessIdentity Sender { get; set; } = null!;
    }
}
