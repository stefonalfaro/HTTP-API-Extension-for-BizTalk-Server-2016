using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class AdmGroup
    {
        public AdmGroup()
        {
            AdmGroupSetting = new HashSet<AdmGroupSetting>();
            AdmHost = new HashSet<AdmHost>();
            AdmMessageBox = new HashSet<AdmMessageBox>();
            AdmReceiveHandler = new HashSet<AdmReceiveHandler>();
            AdmReceiveLocation = new HashSet<AdmReceiveLocation>();
            AdmSendHandler = new HashSet<AdmSendHandler>();
            StaticTrackingInfo = new HashSet<StaticTrackingInfo>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime DateModified { get; set; }
        public string BizTalkAdminGroup { get; set; } = null!;
        public string TrackingDbserverName { get; set; } = null!;
        public string TrackingDbname { get; set; } = null!;
        public string SubscriptionDbserverName { get; set; } = null!;
        public string SubscriptionDbname { get; set; } = null!;
        public string TrackAnalysisServerName { get; set; } = null!;
        public string TrackAnalysisDbname { get; set; } = null!;
        public string BamDbserverName { get; set; } = null!;
        public string BamDbname { get; set; } = null!;
        public string RuleEngineDbserverName { get; set; } = null!;
        public string RuleEngineDbname { get; set; } = null!;
        public string SsoserverName { get; set; } = null!;
        public int GlobalTrackingOption { get; set; }
        public string SignCertName { get; set; } = null!;
        public string SignCertThumbprint { get; set; } = null!;
        public int ConfigurationCacheRefreshInterval { get; set; }
        public byte[] TrackingConfiguration { get; set; } = null!;
        public int LmsfragmentSize { get; set; }
        public int Lmsthreshold { get; set; }
        public int? DefaultHostId { get; set; }
        public string BizTalkOperatorGroup { get; set; } = null!;
        public Guid GroupPropertyIdentifier { get; set; }
        public string BizTalkB2boperatorGroup { get; set; } = null!;
        public Guid Uuid { get; set; }

        public virtual AdmHost? DefaultHost { get; set; }
        public virtual ICollection<AdmGroupSetting> AdmGroupSetting { get; set; }
        public virtual ICollection<AdmHost> AdmHost { get; set; }
        public virtual ICollection<AdmMessageBox> AdmMessageBox { get; set; }
        public virtual ICollection<AdmReceiveHandler> AdmReceiveHandler { get; set; }
        public virtual ICollection<AdmReceiveLocation> AdmReceiveLocation { get; set; }
        public virtual ICollection<AdmSendHandler> AdmSendHandler { get; set; }
        public virtual ICollection<StaticTrackingInfo> StaticTrackingInfo { get; set; }
    }
}
