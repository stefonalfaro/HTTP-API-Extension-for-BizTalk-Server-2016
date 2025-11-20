using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsAssembly
    {
        public BtsAssembly()
        {
            BtMapSpec = new HashSet<BtMapSpec>();
            BtProperties = new HashSet<BtProperties>();
            BtSensitiveProperties = new HashSet<BtSensitiveProperties>();
            BtsItem = new HashSet<BtsItem>();
        }

        public int NId { get; set; }
        public string NvcName { get; set; } = null!;
        public string NvcVersion { get; set; } = null!;
        public string? NvcCulture { get; set; }
        public string? NvcPublicKeyToken { get; set; }
        public string NvcFullName { get; set; } = null!;
        public int NVersionMajor { get; set; }
        public int NVersionMinor { get; set; }
        public int NVersionBuild { get; set; }
        public int NVersionRevision { get; set; }
        public DateTime DtDateModified { get; set; }
        public string NvcModifiedBy { get; set; } = null!;
        public int NType { get; set; }
        public int? NGroupId { get; set; }
        public string? NvcDescription { get; set; }
        public string? NvcIdentity { get; set; }
        public string? NvcType { get; set; }
        public byte? NStrongName { get; set; }
        public string? NtxtModuleXml { get; set; }
        public byte[]? ImgTrackingProfile { get; set; }
        public int NSystemAssembly { get; set; }
        public int NApplicationId { get; set; }

        public virtual BtsApplication NApplication { get; set; } = null!;
        public virtual ICollection<BtMapSpec> BtMapSpec { get; set; }
        public virtual ICollection<BtProperties> BtProperties { get; set; }
        public virtual ICollection<BtSensitiveProperties> BtSensitiveProperties { get; set; }
        public virtual ICollection<BtsItem> BtsItem { get; set; }
    }
}
