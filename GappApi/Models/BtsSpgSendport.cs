using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsSpgSendport
    {
        public int NId { get; set; }
        public int NSendPortGroupId { get; set; }
        public int NSendPortId { get; set; }
        public Guid UidPrimaryGuid { get; set; }
        public Guid UidSecondaryGuid { get; set; }
        public int NSequence { get; set; }
        public DateTime DateModified { get; set; }

        public virtual BtsSendport NSendPort { get; set; } = null!;
        public virtual BtsSendportgroup NSendPortGroup { get; set; } = null!;
    }
}
