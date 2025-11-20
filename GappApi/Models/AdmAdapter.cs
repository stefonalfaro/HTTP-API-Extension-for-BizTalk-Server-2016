using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class AdmAdapter
    {
        public AdmAdapter()
        {
            AdmReceiveHandler = new HashSet<AdmReceiveHandler>();
            AdmReceiveLocation = new HashSet<AdmReceiveLocation>();
            AdmSendHandler = new HashSet<AdmSendHandler>();
            BtsSendportTransport = new HashSet<BtsSendportTransport>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Capabilities { get; set; }
        public string Comment { get; set; } = null!;
        public DateTime DateModified { get; set; }
        public Guid MgmtClsid { get; set; }
        public Guid? InboundEngineClsid { get; set; }
        public string? InboundAssemblyPath { get; set; }
        public string? InboundTypeName { get; set; }
        public Guid? OutboundEngineClsid { get; set; }
        public string? OutboundAssemblyPath { get; set; }
        public string? OutboundTypeName { get; set; }
        public string PropertyNameSpace { get; set; } = null!;
        public string? DefaultRhcfg { get; set; }
        public string? DefaultThcfg { get; set; }

        public virtual ICollection<AdmReceiveHandler> AdmReceiveHandler { get; set; }
        public virtual ICollection<AdmReceiveLocation> AdmReceiveLocation { get; set; }
        public virtual ICollection<AdmSendHandler> AdmSendHandler { get; set; }
        public virtual ICollection<BtsSendportTransport> BtsSendportTransport { get; set; }
    }
}
