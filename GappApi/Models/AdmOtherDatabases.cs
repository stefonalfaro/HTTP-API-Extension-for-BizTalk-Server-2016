using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class AdmOtherDatabases
    {
        public string DefaultDatabaseName { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string ServerName { get; set; } = null!;
        public string BtsserverName { get; set; } = null!;
    }
}
