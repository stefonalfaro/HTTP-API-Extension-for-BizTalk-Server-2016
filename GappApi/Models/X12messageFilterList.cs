using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class X12messageFilterList
    {
        public int FilterListId { get; set; }
        public int SettingsId { get; set; }
        public string MessageId { get; set; } = null!;
        public byte[] Version { get; set; } = null!;

        public virtual X12protocolSettings Settings { get; set; } = null!;
    }
}
