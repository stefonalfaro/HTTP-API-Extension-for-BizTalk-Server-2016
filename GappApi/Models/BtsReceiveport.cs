using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsReceiveport
    {
        public BtsReceiveport()
        {
            AdmReceiveLocation = new HashSet<AdmReceiveLocation>();
            BtsOrchestrationPortBinding = new HashSet<BtsOrchestrationPortBinding>();
            BtsReceiveportTransform = new HashSet<BtsReceiveportTransform>();
        }

        public int NId { get; set; }
        public string NvcName { get; set; } = null!;
        public bool BTwoWay { get; set; }
        public int NAuthentication { get; set; }
        public int? NSendPipelineId { get; set; }
        public string? NvcSendPipelineData { get; set; }
        public int? NTracking { get; set; }
        public Guid UidGuid { get; set; }
        public string? NvcCustomData { get; set; }
        public DateTime DateModified { get; set; }
        public int NApplicationId { get; set; }
        public string? NvcDescription { get; set; }
        public bool? BRouteFailedMessage { get; set; }

        public virtual BtsApplication NApplication { get; set; } = null!;
        public virtual BtsPipeline? NSendPipeline { get; set; }
        public virtual ICollection<AdmReceiveLocation> AdmReceiveLocation { get; set; }
        public virtual ICollection<BtsOrchestrationPortBinding> BtsOrchestrationPortBinding { get; set; }
        public virtual ICollection<BtsReceiveportTransform> BtsReceiveportTransform { get; set; }
    }
}
