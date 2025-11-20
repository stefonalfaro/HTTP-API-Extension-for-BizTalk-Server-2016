using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsPipeline
    {
        public BtsPipeline()
        {
            AdmReceiveLocationReceivePipeline = new HashSet<AdmReceiveLocation>();
            AdmReceiveLocationSendPipeline = new HashSet<AdmReceiveLocation>();
            BtsReceiveport = new HashSet<BtsReceiveport>();
            BtsSendportNReceivePipeline = new HashSet<BtsSendport>();
            BtsSendportNSendPipeline = new HashSet<BtsSendport>();
        }

        public int Id { get; set; }
        public Guid PipelineId { get; set; }
        public short Category { get; set; }
        public string Name { get; set; } = null!;
        public string FullyQualifiedName { get; set; } = null!;
        public short IsStreaming { get; set; }
        public int NAssemblyId { get; set; }
        public string? NvcDescription { get; set; }
        public int Release { get; set; }

        public virtual ICollection<AdmReceiveLocation> AdmReceiveLocationReceivePipeline { get; set; }
        public virtual ICollection<AdmReceiveLocation> AdmReceiveLocationSendPipeline { get; set; }
        public virtual ICollection<BtsReceiveport> BtsReceiveport { get; set; }
        public virtual ICollection<BtsSendport> BtsSendportNReceivePipeline { get; set; }
        public virtual ICollection<BtsSendport> BtsSendportNSendPipeline { get; set; }
    }
}
