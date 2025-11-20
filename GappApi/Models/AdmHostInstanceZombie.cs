using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class AdmHostInstanceZombie
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string GroupName { get; set; } = null!;
        public string HostName { get; set; } = null!;
        public string ServerName { get; set; } = null!;
        public DateTime DateModified { get; set; }
        public string NtgroupName { get; set; } = null!;
        public string LoginName { get; set; } = null!;
        public Guid UniqueId { get; set; }
    }
}
