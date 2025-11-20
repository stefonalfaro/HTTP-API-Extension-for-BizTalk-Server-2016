using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsItemreference
    {
        public int NReferringAssemblyId { get; set; }
        public string NvcAssemblyName { get; set; } = null!;
        public string NvcVersionMajor { get; set; } = null!;
        public string NvcVersionMinor { get; set; } = null!;
        public string NvcVersionBuild { get; set; } = null!;
        public string NvcVersionRevision { get; set; } = null!;
        public string NvcItemName { get; set; } = null!;
        public string NvcCulture { get; set; } = null!;
        public string NvcPublicKeyToken { get; set; } = null!;
    }
}
