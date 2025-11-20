using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class EdifactvalidationOverrides
    {
        public int OverridesId { get; set; }
        public int SettingsId { get; set; }
        public string MessageId { get; set; } = null!;
        public bool EnforceCharacterSet { get; set; }
        public bool ValidateEditypes { get; set; }
        public bool ValidateExtended { get; set; }
        public bool TrimLeadingAndTrailingSpacesAndZeroes { get; set; }
        public bool AllowLeadingAndTrailingSpacesAndZeroes { get; set; }
        public short TrailingSeparatorPolicy { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual EdifactprotocolSettings Settings { get; set; } = null!;
    }
}
