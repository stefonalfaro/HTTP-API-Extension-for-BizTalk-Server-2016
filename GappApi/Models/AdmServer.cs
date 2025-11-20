using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class AdmServer
    {
        public AdmServer()
        {
            AdmServer2HostMapping = new HashSet<AdmServer2HostMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime DateModified { get; set; }

        public virtual ICollection<AdmServer2HostMapping> AdmServer2HostMapping { get; set; }
    }
}
