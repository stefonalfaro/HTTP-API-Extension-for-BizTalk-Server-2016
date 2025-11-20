using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class AdmBackupSettings
    {
        public bool UseCompression { get; set; }
        public bool ForceFull { get; set; }
    }
}
