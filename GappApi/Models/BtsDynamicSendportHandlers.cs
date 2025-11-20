using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsDynamicSendportHandlers
    {
        public int NId { get; set; }
        public Guid UidSendPortId { get; set; }
        public int SendHandlerId { get; set; }

        public virtual AdmSendHandler SendHandler { get; set; } = null!;
    }
}
