using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class AdmServiceClass
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public Guid UniqueId { get; set; }
        public int LowWatermark { get; set; }
        public int HighWatermark { get; set; }
        public int BatchSize { get; set; }
        public int SingleDequeueSession { get; set; }
        public int SerializeInstanceDelivery { get; set; }
        public int GroupBatchByInstance { get; set; }
        public int LowMemorymark { get; set; }
        public int HighMemorymark { get; set; }
        public int ThrottleFlag { get; set; }
        public int LowSessionmark { get; set; }
        public int HighSessionmark { get; set; }
        public int CacheInstanceState { get; set; }
        public int MaxDequeueThread { get; set; }
    }
}
