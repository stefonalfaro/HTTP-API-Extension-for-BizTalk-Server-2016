using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsSendportTransport
    {
        public int NId { get; set; }
        public string NvcAddress { get; set; } = null!;
        public int? NTransportTypeId { get; set; }
        public string? NvcTransportTypeData { get; set; }
        public bool BOrderedDelivery { get; set; }
        public int NDeliveryNotification { get; set; }
        public int NRetryCount { get; set; }
        public int NRetryInterval { get; set; }
        public bool BIsServiceWindow { get; set; }
        public DateTime DtFromTime { get; set; }
        public DateTime DtToTime { get; set; }
        public bool BIsPrimary { get; set; }
        public bool BSsomappingExists { get; set; }
        public int NSendPortId { get; set; }
        public Guid? UidGuid { get; set; }
        public DateTime DateModified { get; set; }
        public int? NSendHandlerId { get; set; }

        public virtual AdmSendHandler? NSendHandler { get; set; }
        public virtual BtsSendport NSendPort { get; set; } = null!;
        public virtual AdmAdapter? NTransportType { get; set; }
    }
}
