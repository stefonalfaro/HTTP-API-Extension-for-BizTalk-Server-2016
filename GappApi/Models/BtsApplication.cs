using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsApplication
    {
        public BtsApplication()
        {
            AdplSat = new HashSet<AdplSat>();
            BtsApplicationReferenceNApplication = new HashSet<BtsApplicationReference>();
            BtsApplicationReferenceNReferencedApplication = new HashSet<BtsApplicationReference>();
            BtsAssembly = new HashSet<BtsAssembly>();
            BtsReceiveport = new HashSet<BtsReceiveport>();
            BtsSendport = new HashSet<BtsSendport>();
            BtsSendportgroup = new HashSet<BtsSendportgroup>();
        }

        public int NId { get; set; }
        public string NvcName { get; set; } = null!;
        public bool IsDefault { get; set; }
        public bool IsSystem { get; set; }
        public string? NvcDescription { get; set; }
        public DateTime DateModified { get; set; }

        public virtual ICollection<AdplSat> AdplSat { get; set; }
        public virtual ICollection<BtsApplicationReference> BtsApplicationReferenceNApplication { get; set; }
        public virtual ICollection<BtsApplicationReference> BtsApplicationReferenceNReferencedApplication { get; set; }
        public virtual ICollection<BtsAssembly> BtsAssembly { get; set; }
        public virtual ICollection<BtsReceiveport> BtsReceiveport { get; set; }
        public virtual ICollection<BtsSendport> BtsSendport { get; set; }
        public virtual ICollection<BtsSendportgroup> BtsSendportgroup { get; set; }
    }
}
