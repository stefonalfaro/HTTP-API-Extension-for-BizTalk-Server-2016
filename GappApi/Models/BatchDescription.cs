using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BatchDescription
    {
        public BatchDescription()
        {
            PamControl = new HashSet<PamControl>();
        }

        public long Id { get; set; }
        public int OnewayAgreementId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string Protocol { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TerminationCount { get; set; }
        public byte[]? FilterBytes { get; set; }
        public short ReleaseCriteriaType { get; set; }
        public int MessageCount { get; set; }
        public short? MessageScope { get; set; }
        public long InterchangeSize { get; set; }
        public short RecurrenceType { get; set; }
        public DateTime FirstRelease { get; set; }
        public long RecurrenceTicks { get; set; }
        public int WeekDays { get; set; }
        public bool SendEmptyBatchSignal { get; set; }
        public bool Modified { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual OnewayAgreement OnewayAgreement { get; set; } = null!;
        public virtual ICollection<PamControl> PamControl { get; set; }
    }
}
