using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class X12envelopesOverrides
    {
        public int OverridesId { get; set; }
        public int SettingsId { get; set; }
        public string? TargetNamespace { get; set; }
        public string? ProtocolVersion { get; set; }
        public string MessageId { get; set; } = null!;
        public string? SenderApplicationId { get; set; }
        public string? ReceiverApplicationId { get; set; }
        public string? FunctionalIdentifierCode { get; set; }
        public short DateFormat { get; set; }
        public short TimeFormat { get; set; }
        public short ResponsibleAgencyCode { get; set; }
        public string? HeaderVersion { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual X12protocolSettings Settings { get; set; } = null!;
    }
}
