using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtMapSpec
    {
        public BtMapSpec()
        {
            BtsReceiveportTransform = new HashSet<BtsReceiveportTransform>();
            BtsSendportTransform = new HashSet<BtsSendportTransform>();
        }

        public Guid Id { get; set; }
        public int Itemid { get; set; }
        public int Assemblyid { get; set; }
        public Guid? Shareid { get; set; }
        public string? IndocNamespace { get; set; }
        public string? OutdocNamespace { get; set; }
        public string? IndocDocspecName { get; set; }
        public string? OutdocDocspecName { get; set; }
        public DateTime DateModified { get; set; }
        public string? Description { get; set; }

        public virtual BtsAssembly Assembly { get; set; } = null!;
        public virtual BtsItem Item { get; set; } = null!;
        public virtual BtXmlshare? Share { get; set; }
        public virtual ICollection<BtsReceiveportTransform> BtsReceiveportTransform { get; set; }
        public virtual ICollection<BtsSendportTransform> BtsSendportTransform { get; set; }
    }
}
