using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class XrefMessageArgument
    {
        public int MsgId { get; set; }
        public byte ArgSequenceNum { get; set; }
        public string ArgName { get; set; } = null!;
        public int? ArgIdxrefId { get; set; }
        public int? ArgValueXrefId { get; set; }
    }
}
