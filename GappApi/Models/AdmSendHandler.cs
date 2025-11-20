using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class AdmSendHandler
    {
        public AdmSendHandler()
        {
            BtsDynamicSendportHandlers = new HashSet<BtsDynamicSendportHandlers>();
            BtsSendportTransport = new HashSet<BtsSendportTransport>();
        }

        public int Id { get; set; }
        public int GroupId { get; set; }
        public int AdapterId { get; set; }
        public int? HostId { get; set; }
        public bool IsDefault { get; set; }
        public string? CustomCfg { get; set; }
        public DateTime DateModified { get; set; }
        public Guid? SubscriptionId { get; set; }
        public Guid UidCustomCfgId { get; set; }
        public Guid UidTransmitLocationSsoappId { get; set; }
        public string? NvcDescription { get; set; }

        public virtual AdmAdapter Adapter { get; set; } = null!;
        public virtual AdmGroup Group { get; set; } = null!;
        public virtual AdmHost? Host { get; set; }
        public virtual ICollection<BtsDynamicSendportHandlers> BtsDynamicSendportHandlers { get; set; }
        public virtual ICollection<BtsSendportTransport> BtsSendportTransport { get; set; }
    }
}
