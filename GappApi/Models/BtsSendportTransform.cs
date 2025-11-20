using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsSendportTransform
    {
        public int NId { get; set; }
        public int NSendPortId { get; set; }
        public Guid UidTransformGuid { get; set; }
        public bool BReceive { get; set; }
        public int NSequence { get; set; }
        public DateTime DateModified { get; set; }

        public virtual BtsSendport NSendPort { get; set; } = null!;
        public virtual BtMapSpec UidTransformGu { get; set; } = null!;
    }
}
