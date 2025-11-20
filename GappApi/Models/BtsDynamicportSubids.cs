using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsDynamicportSubids
    {
        public Guid UidSendPortId { get; set; }
        public int NSendHandlerId { get; set; }
        public Guid UidGuid { get; set; }
        public string? NvcHostName { get; set; }
    }
}
