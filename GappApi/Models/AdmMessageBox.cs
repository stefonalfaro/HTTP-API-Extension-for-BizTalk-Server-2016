using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class AdmMessageBox
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public DateTime DateModified { get; set; }
        public string DbserverName { get; set; } = null!;
        public string Dbname { get; set; } = null!;
        public int DisableNewMsgPublication { get; set; }
        public int ConfigurationState { get; set; }
        public Guid UniqueId { get; set; }
        public int IsMasterMsgBox { get; set; }
        public string? NvcDescription { get; set; }

        public virtual AdmGroup Group { get; set; } = null!;
    }
}
