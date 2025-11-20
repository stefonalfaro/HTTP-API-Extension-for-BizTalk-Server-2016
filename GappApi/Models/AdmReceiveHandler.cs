using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class AdmReceiveHandler
    {
        public AdmReceiveHandler()
        {
            AdmReceiveLocation = new HashSet<AdmReceiveLocation>();
        }

        public int Id { get; set; }
        public int GroupId { get; set; }
        public int AdapterId { get; set; }
        public int? HostId { get; set; }
        public string? CustomCfg { get; set; }
        public Guid UidCustomCfgId { get; set; }
        public Guid UidReceiveLocationSsoappId { get; set; }
        public DateTime DateModified { get; set; }
        public string? NvcDescription { get; set; }

        public virtual AdmAdapter Adapter { get; set; } = null!;
        public virtual AdmGroup Group { get; set; } = null!;
        public virtual AdmHost? Host { get; set; }
        public virtual ICollection<AdmReceiveLocation> AdmReceiveLocation { get; set; }
    }
}
