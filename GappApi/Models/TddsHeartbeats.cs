using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class TddsHeartbeats
    {
        public Guid? ServiceId { get; set; }
        public Guid? SourceId { get; set; }
        public int Age { get; set; }
        public DateTime? TimeLastChanged { get; set; }
        public int? RecordsProcessed { get; set; }
        public double? Latency { get; set; }
        public int? EventsProcessed { get; set; }
        public int? RecordsLeft { get; set; }
        public int? ErrorCode { get; set; }
        public string? ErrorDescription { get; set; }

        public virtual TddsServices? Service { get; set; }
    }
}
