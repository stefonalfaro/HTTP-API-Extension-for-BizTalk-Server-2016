using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class XrefMessageText
    {
        public string Lang { get; set; } = null!;
        public int MsgId { get; set; }
        public string MsgText { get; set; } = null!;
    }
}
