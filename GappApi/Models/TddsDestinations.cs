using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class TddsDestinations
    {
        public TddsDestinations()
        {
            TddsSources = new HashSet<TddsSources>();
        }

        public Guid DestinationId { get; set; }
        public string? DestinationName { get; set; }
        public string ConnectionString { get; set; } = null!;

        public virtual ICollection<TddsSources> TddsSources { get; set; }
    }
}
