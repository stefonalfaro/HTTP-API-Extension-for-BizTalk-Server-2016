using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class TrackinginterceptorVersions
    {
        public Guid UidRootInterceptorId { get; set; }
        public Guid UidInterceptorId { get; set; }
        public string AssemblyName { get; set; } = null!;
        public string TypeName { get; set; } = null!;
        public DateTime DtDeploymentTime { get; set; }

        public virtual Trackinginterceptor UidRootInterceptor { get; set; } = null!;
    }
}
