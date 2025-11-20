using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsReceiveportTransform
    {
        public int NId { get; set; }
        public int NReceivePortId { get; set; }
        public Guid UidTransformGuid { get; set; }
        public bool BTransmit { get; set; }
        public int NSequence { get; set; }
        public DateTime DateModified { get; set; }

        public virtual BtsReceiveport NReceivePort { get; set; } = null!;
        public virtual BtMapSpec UidTransformGu { get; set; } = null!;
    }
}
