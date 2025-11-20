using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BizTalkDbversion
    {
        public string BizTalkDbname { get; set; } = null!;
        public int DatabaseMajor { get; set; }
        public int DatabaseMinor { get; set; }
        public int DatabaseBuildNumber { get; set; }
        public int DatabaseRevision { get; set; }
        public int ProductMajor { get; set; }
        public int ProductMinor { get; set; }
        public int ProductBuildNumber { get; set; }
        public int ProductRevision { get; set; }
        public string ProductLanguage { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime? Modified { get; set; }
    }
}
