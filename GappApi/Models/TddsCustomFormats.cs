using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class TddsCustomFormats
    {
        public Guid FormatId { get; set; }
        public string DecoderClass { get; set; } = null!;
        public string DllName { get; set; } = null!;
    }
}
