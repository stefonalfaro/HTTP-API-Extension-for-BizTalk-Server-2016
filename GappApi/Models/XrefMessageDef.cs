using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class XrefMessageDef
    {
        public int MsgId { get; set; }
        public string MsgCode { get; set; } = null!;
        public string? Description { get; set; }
    }
}
