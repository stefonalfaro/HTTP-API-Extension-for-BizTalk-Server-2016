using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsEnlistedpartyOperationMapping
    {
        public int NId { get; set; }
        public int NOperationId { get; set; }
        public int NPartySendPortId { get; set; }
        public int NPortMappingId { get; set; }
        public DateTime DateModified { get; set; }

        public virtual BtsPorttypeOperation NOperation { get; set; } = null!;
        public virtual SendPortReference NPartySendPort { get; set; } = null!;
        public virtual BtsEnlistedpartyPortMapping NPortMapping { get; set; } = null!;
    }
}
