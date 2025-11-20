using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsvVersionIndependentOrchestration
    {
        public int? NOrchestrationId { get; set; }
        public string? NvcOrchestrationName { get; set; }
        public string? NvcAssemblyName { get; set; }
        public string? NvcAssemblyCulture { get; set; }
        public string? NvcAssemblyPublicKeyToken { get; set; }
        public string? NvcAssemblyFullName { get; set; }
        public DateTime? DtDateModified { get; set; }
        public int? NAdminGroupId { get; set; }
        public int? NAdminHostId { get; set; }
        public int? NOrchestrationStatus { get; set; }
    }
}
