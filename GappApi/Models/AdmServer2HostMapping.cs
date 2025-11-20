using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class AdmServer2HostMapping
    {
        public int Id { get; set; }
        public int ServerId { get; set; }
        public int HostId { get; set; }
        public DateTime DateModified { get; set; }
        public int IsMapped { get; set; }

        public virtual AdmHost Host { get; set; } = null!;
        public virtual AdmServer Server { get; set; } = null!;
        public virtual AdmHostInstance? AdmHostInstance { get; set; }
    }
}
