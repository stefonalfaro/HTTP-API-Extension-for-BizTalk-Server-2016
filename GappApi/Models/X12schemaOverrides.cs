using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class X12schemaOverrides
    {
        public int OverridesId { get; set; }
        public int SettingsId { get; set; }
        public string MessageId { get; set; } = null!;
        public string? SenderApplicationId { get; set; }
        public string? GstargetNamespace { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual X12protocolSettings Settings { get; set; } = null!;
    }
}
