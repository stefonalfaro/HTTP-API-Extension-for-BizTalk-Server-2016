using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtXmlshareReferences
    {
        public Guid Shareid { get; set; }
        public string TargetNamespace { get; set; } = null!;

        public virtual BtXmlshare Share { get; set; } = null!;
    }
}
