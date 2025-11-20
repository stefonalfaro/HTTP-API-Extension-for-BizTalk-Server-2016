using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsSendport
    {
        public BtsSendport()
        {
            BtsOrchestrationPortBinding = new HashSet<BtsOrchestrationPortBinding>();
            BtsSendportTransform = new HashSet<BtsSendportTransform>();
            BtsSendportTransport = new HashSet<BtsSendportTransport>();
            BtsSpgSendport = new HashSet<BtsSpgSendport>();
            SendPortReference = new HashSet<SendPortReference>();
        }

        public int NId { get; set; }
        public string NvcName { get; set; } = null!;
        public int? NApplicationTypeId { get; set; }
        public string? NvcApplicationTypeData { get; set; }
        public string? NvcEncryptionCert { get; set; }
        public string? NvcEncryptionCertHash { get; set; }
        public int NSendPipelineId { get; set; }
        public string? NvcSendPipelineData { get; set; }
        public bool BDynamic { get; set; }
        public bool BTwoWay { get; set; }
        public int? NReceivePipelineId { get; set; }
        public string? NvcReceivePipelineData { get; set; }
        public int? NTracking { get; set; }
        public int NPortStatus { get; set; }
        public string NvcFilter { get; set; } = null!;
        public Guid UidGuid { get; set; }
        public string? NvcCustomData { get; set; }
        public int NPriority { get; set; }
        public DateTime DateModified { get; set; }
        public int NApplicationId { get; set; }
        public string? NvcDescription { get; set; }
        public bool? BStopSendingOnFailure { get; set; }
        public bool? BRouteFailedMessage { get; set; }
        public bool BOrderedDeliveryforDynamicPort { get; set; }

        public virtual BtsApplication NApplication { get; set; } = null!;
        public virtual BtsPipeline? NReceivePipeline { get; set; }
        public virtual BtsPipeline NSendPipeline { get; set; } = null!;
        public virtual ICollection<BtsOrchestrationPortBinding> BtsOrchestrationPortBinding { get; set; }
        public virtual ICollection<BtsSendportTransform> BtsSendportTransform { get; set; }
        public virtual ICollection<BtsSendportTransport> BtsSendportTransport { get; set; }
        public virtual ICollection<BtsSpgSendport> BtsSpgSendport { get; set; }
        public virtual ICollection<SendPortReference> SendPortReference { get; set; }
    }
}
