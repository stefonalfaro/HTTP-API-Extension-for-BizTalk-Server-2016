using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class EdifactenvelopeOverrides
    {
        public int OverridesId { get; set; }
        public int SettingsId { get; set; }
        public string MessageId { get; set; } = null!;
        public string MessageVersion { get; set; } = null!;
        public string MessageRelease { get; set; } = null!;
        public string? MessageAssociationAssignedCode { get; set; }
        public string TargetNamespace { get; set; } = null!;
        public string? FunctionalGroupId { get; set; }
        public string? SenderApplicationQualifier { get; set; }
        public string? SenderApplicationId { get; set; }
        public string? ReceiverApplicationQualifier { get; set; }
        public string? ReceiverApplicationId { get; set; }
        public string? ControllingAgencyCode { get; set; }
        public string? GroupHeaderMessageVersion { get; set; }
        public string? GroupHeaderMessageRelease { get; set; }
        public string? AssociationAssignedCode { get; set; }
        public Guid? Ssoidentifier { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual EdifactprotocolSettings Settings { get; set; } = null!;
    }
}
