using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BamActivityToOrchestrationMapping
    {
        public string ActivityName { get; set; } = null!;
        public Guid ServiceId { get; set; }
    }
}
