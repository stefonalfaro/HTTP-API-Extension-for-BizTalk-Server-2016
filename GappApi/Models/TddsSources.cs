using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class TddsSources
    {
        public Guid SourceId { get; set; }
        public Guid? DestinationId { get; set; }
        public string? SourceName { get; set; }
        public string ConnectionString { get; set; } = null!;
        public int? StreamType { get; set; }
        public int? AcceptableLatency { get; set; }
        public bool? Enabled { get; set; }

        public virtual TddsDestinations? Destination { get; set; }
    }
}
