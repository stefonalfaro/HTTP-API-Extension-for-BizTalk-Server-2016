using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class Trackinginterceptor
    {
        public Trackinginterceptor()
        {
            TrackinginterceptorVersions = new HashSet<TrackinginterceptorVersions>();
        }

        public Guid UidInterceptorId { get; set; }
        public int InterceptorType { get; set; }
        public string AssemblyName { get; set; } = null!;
        public string TypeName { get; set; } = null!;

        public virtual ICollection<TrackinginterceptorVersions> TrackinginterceptorVersions { get; set; }
    }
}
