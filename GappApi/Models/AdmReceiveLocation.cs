using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class AdmReceiveLocation
    {
        public int Id { get; set; }
        public int AdapterId { get; set; }
        public string Name { get; set; } = null!;
        public int? ReceiveHandlerId { get; set; }
        public int? GroupId { get; set; }
        public DateTime DateModified { get; set; }
        public string Comment { get; set; } = null!;
        public int OperatingWindowEnabled { get; set; }
        public DateTime? ActiveStartDt { get; set; }
        public DateTime? ActiveStopDt { get; set; }
        public bool StartDtenabled { get; set; }
        public DateTime? SrvWinStartDt { get; set; }
        public bool StopDtenabled { get; set; }
        public DateTime? SrvWinStopDt { get; set; }
        public int Disabled { get; set; }
        public string? CustomCfg { get; set; }
        public Guid? UidCustomCfgId { get; set; }
        public bool BSsomappingExists { get; set; }
        public string InboundTransportUrl { get; set; } = null!;
        public string? InboundAddressableUrl { get; set; }
        public int? ReceivePipelineId { get; set; }
        public string? ReceivePipelineData { get; set; }
        public int ReceivePortId { get; set; }
        public int IsPrimary { get; set; }
        public int Fragmentation { get; set; }
        public string? NvcCustomData { get; set; }
        public int? SendPipelineId { get; set; }
        public string? EncryptionCert { get; set; }
        public string? EncryptionCertThumbPrint { get; set; }
        public string? Description { get; set; }
        public string? SendPipelineData { get; set; }

        public virtual AdmAdapter Adapter { get; set; } = null!;
        public virtual AdmGroup? Group { get; set; }
        public virtual AdmReceiveHandler? ReceiveHandler { get; set; }
        public virtual BtsPipeline? ReceivePipeline { get; set; }
        public virtual BtsReceiveport ReceivePort { get; set; } = null!;
        public virtual BtsPipeline? SendPipeline { get; set; }
    }
}
