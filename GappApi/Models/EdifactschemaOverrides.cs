using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class EdifactschemaOverrides
    {
        public int OverridesId { get; set; }
        public int SettingsId { get; set; }
        public string? MessageId { get; set; }
        public string MessageVersion { get; set; } = null!;
        public string MessageRelease { get; set; } = null!;
        public string? ApplicationSenderId { get; set; }
        public string? ApplicationSenderQualifier { get; set; }
        public string? AssociationAssignedCode { get; set; }
        public string TargetNamespace { get; set; } = null!;
        public byte[] Version { get; set; } = null!;

        public virtual EdifactprotocolSettings Settings { get; set; } = null!;
    }
}
