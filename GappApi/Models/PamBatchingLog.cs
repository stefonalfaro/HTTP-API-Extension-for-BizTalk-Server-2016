using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class PamBatchingLog
    {
        public Guid? BatchOrchestrationId { get; set; }
        public int? NumOccurences { get; set; }
        public long BatchId { get; set; }
    }
}
