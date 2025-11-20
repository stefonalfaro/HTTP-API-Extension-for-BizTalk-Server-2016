using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsOperationMsgtype
    {
        public int NId { get; set; }
        public int NOperationId { get; set; }
        public int NMessageTypeId { get; set; }
        public int NType { get; set; }

        public virtual BtsPorttypeOperation NOperation { get; set; } = null!;
    }
}
