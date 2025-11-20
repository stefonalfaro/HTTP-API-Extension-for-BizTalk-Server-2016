using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class AdmBackupHistory
    {
        public long BackupId { get; set; }
        public long BackupSetId { get; set; }
        public string? MarkName { get; set; }
        public string DatabaseName { get; set; } = null!;
        public string BackupFileName { get; set; } = null!;
        public string BackupFileLocation { get; set; } = null!;
        public string BackupType { get; set; } = null!;
        public DateTime BackupDateTime { get; set; }
        public bool SetComplete { get; set; }
        public string? ServerName { get; set; }
    }
}
