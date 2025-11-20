using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsOrchestrationInvocation
    {
        public int NId { get; set; }
        public int NOrchestrationId { get; set; }
        public int NInvokedOrchestrationId { get; set; }
        public byte NInvokeType { get; set; }

        public virtual BtsOrchestration NOrchestration { get; set; } = null!;
    }
}
