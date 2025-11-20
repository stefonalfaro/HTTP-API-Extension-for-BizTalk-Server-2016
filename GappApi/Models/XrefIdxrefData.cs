using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class XrefIdxrefData
    {
        public int IdXrefId { get; set; }
        public int AppInstanceId { get; set; }
        public string AppId { get; set; } = null!;
        public string CommonId { get; set; } = null!;
    }
}
