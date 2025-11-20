using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsPortActivationOperation
    {
        public int NId { get; set; }
        public int NOrchestrationId { get; set; }
        public int NPortId { get; set; }
        public int? NOperationId { get; set; }

        public virtual BtsPorttypeOperation? NOperation { get; set; }
        public virtual BtsOrchestration NOrchestration { get; set; } = null!;
    }
}
