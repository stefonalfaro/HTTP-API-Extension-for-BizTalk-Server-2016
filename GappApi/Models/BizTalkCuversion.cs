using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BizTalkCuversion
    {
        public int Cu { get; set; }
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Build { get; set; }
        public int Revision { get; set; }
        public DateTime? Modified { get; set; }
    }
}
