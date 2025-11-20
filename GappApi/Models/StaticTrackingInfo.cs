using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class StaticTrackingInfo
    {
        public int? GroupId { get; set; }
        public string StrServiceName { get; set; } = null!;
        public Guid UidServiceId { get; set; }
        public Guid UidInterceptorId { get; set; }
        public DateTime DtDeploymentTime { get; set; }
        public DateTime? DtUndeploymentTime { get; set; }
        public int IsmsgBodyTrackingEnabled { get; set; }
        public byte[]? ImgData { get; set; }

        public virtual AdmGroup? Group { get; set; }
    }
}
