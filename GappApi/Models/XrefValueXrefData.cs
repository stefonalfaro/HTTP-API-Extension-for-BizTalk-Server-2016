using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class XrefValueXrefData
    {
        public int ValueXrefId { get; set; }
        public int AppTypeId { get; set; }
        public string AppValue { get; set; } = null!;
        public string CommonValue { get; set; } = null!;
    }
}
