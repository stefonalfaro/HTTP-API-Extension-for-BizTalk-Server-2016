using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class AdmHostInstance
    {
        public AdmHostInstance()
        {
            AdmHostInstanceSetting = new HashSet<AdmHostInstanceSetting>();
        }

        public int Id { get; set; }
        public int Svr2HostMappingId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime DateModified { get; set; }
        public string LoginName { get; set; } = null!;
        public int DisableHostInstance { get; set; }
        public int ConfigurationState { get; set; }
        public Guid UniqueId { get; set; }
        public string InstallationContext { get; set; } = null!;
        public string? NvcDescription { get; set; }

        public virtual AdmServer2HostMapping Svr2HostMapping { get; set; } = null!;
        public virtual ICollection<AdmHostInstanceSetting> AdmHostInstanceSetting { get; set; }
    }
}
