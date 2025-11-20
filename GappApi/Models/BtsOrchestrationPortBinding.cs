using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsOrchestrationPortBinding
    {
        public int NId { get; set; }
        public int NOrcPortId { get; set; }
        public int? NReceivePortId { get; set; }
        public int? NSendPortId { get; set; }
        public int? NSpgId { get; set; }
        public DateTime DateModified { get; set; }

        public virtual BtsOrchestrationPort NOrcPort { get; set; } = null!;
        public virtual BtsReceiveport? NReceivePort { get; set; }
        public virtual BtsSendport? NSendPort { get; set; }
        public virtual BtsSendportgroup? NSpg { get; set; }
    }
}
