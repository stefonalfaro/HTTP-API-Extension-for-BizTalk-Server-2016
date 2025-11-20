using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class AdmHost
    {
        public AdmHost()
        {
            AdmGroup = new HashSet<AdmGroup>();
            AdmHostSetting = new HashSet<AdmHostSetting>();
            AdmReceiveHandler = new HashSet<AdmReceiveHandler>();
            AdmSendHandler = new HashSet<AdmSendHandler>();
            AdmServer2HostMapping = new HashSet<AdmServer2HostMapping>();
        }

        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; } = null!;
        public string NtgroupName { get; set; } = null!;
        public DateTime DateModified { get; set; }
        public string LastUsedLogon { get; set; } = null!;
        public int HostTracking { get; set; }
        public int AuthTrusted { get; set; }
        public int HostType { get; set; }
        public string DecryptCertName { get; set; } = null!;
        public string DecryptCertThumbprint { get; set; } = null!;
        public string ClusterResourceGroupName { get; set; } = null!;
        public bool IsHost32BitOnly { get; set; }
        public int MessageDeliverySampleSpaceSize { get; set; }
        public int MessageDeliverySampleSpaceWindow { get; set; }
        public int MessageDeliveryOverdriveFactor { get; set; }
        public int MessageDeliveryMaximumDelay { get; set; }
        public int MessagePublishSampleSpaceSize { get; set; }
        public int MessagePublishSampleSpaceWindow { get; set; }
        public int MessagePublishOverdriveFactor { get; set; }
        public int MessagePublishMaximumDelay { get; set; }
        public int DeliveryQueueSize { get; set; }
        public int DbsessionThreshold { get; set; }
        public int GlobalMemoryThreshold { get; set; }
        public int ProcessMemoryThreshold { get; set; }
        public int ThreadThreshold { get; set; }
        public int DbqueueSizeThreshold { get; set; }
        public int InflightMessageThreshold { get; set; }
        public int ThreadPoolSize { get; set; }

        public virtual AdmGroup Group { get; set; } = null!;
        public virtual ICollection<AdmGroup> AdmGroup { get; set; }
        public virtual ICollection<AdmHostSetting> AdmHostSetting { get; set; }
        public virtual ICollection<AdmReceiveHandler> AdmReceiveHandler { get; set; }
        public virtual ICollection<AdmSendHandler> AdmSendHandler { get; set; }
        public virtual ICollection<AdmServer2HostMapping> AdmServer2HostMapping { get; set; }
    }
}
