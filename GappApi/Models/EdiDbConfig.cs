using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class EdiDbConfig
    {
        public string? EdiRuntimeDbServerName { get; set; }
        public string? EdiRuntimeDbName { get; set; }
        public bool EdiEnabled { get; set; }
        public bool As2enabled { get; set; }
        public bool ReportingEnabled { get; set; }
        public bool EdiConfigured { get; set; }
        public bool As2configured { get; set; }
        public bool ReportingConfigured { get; set; }
        public string? SsoApplicationName { get; set; }
    }
}
