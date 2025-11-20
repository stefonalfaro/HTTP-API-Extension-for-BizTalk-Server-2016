using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BamTrackPoints
    {
        public int NTrackPointId { get; set; }
        public int NProfileId { get; set; }
        public string? NvcMsgType { get; set; }
        public Guid UidPortId { get; set; }
        public int NDirection { get; set; }
        public string NtxtData { get; set; } = null!;
    }
}
