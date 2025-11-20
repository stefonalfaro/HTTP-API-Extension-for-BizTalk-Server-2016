using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class As2protocolSettings
    {
        public int SettingsId { get; set; }
        public bool IgnoreCertificateNameMismatch { get; set; }
        public bool HttpExpect100Continue { get; set; }
        public bool KeepHttpConnectionAlive { get; set; }
        public bool UnfoldHttpHeaders { get; set; }
        public bool AckIgnoreCertificateNameMismatch { get; set; }
        public bool AckHttpExpect100Continue { get; set; }
        public bool AckKeepHttpConnectionAlive { get; set; }
        public bool AckUnfoldHttpHeaders { get; set; }
        public bool MessageEncrypted { get; set; }
        public bool MessageSigned { get; set; }
        public bool MessageCompressed { get; set; }
        public short EncryptionAlgorithm { get; set; }
        public bool CheckDuplicateInterchangeControlNumber { get; set; }
        public short InterchangeDuplicatesValidity { get; set; }
        public bool CheckCertificateRevocationListOnSend { get; set; }
        public bool CheckCertificateRevocationListOnReceive { get; set; }
        public bool OverrideMessageProperties { get; set; }
        public bool SuspendDuplicateMessage { get; set; }
        public bool ProcessMdntoMsgBox { get; set; }
        public bool TransmitFileNameInMimeHeader { get; set; }
        public string? FileNameTemplate { get; set; }
        public bool SuspendMessageOnFileNameGenerationError { get; set; }
        public bool AutogenerateFileName { get; set; }
        public string MessageContentType { get; set; } = null!;
        public bool NeedMdn { get; set; }
        public bool NeedSignedMdn { get; set; }
        public short MdnHashingAlgorithm { get; set; }
        public bool NeedAsynchronousMdn { get; set; }
        public string? ReceiptDeliveryUrl { get; set; }
        public string? DispositionNotificationTo { get; set; }
        public bool ResendIfMdnNotReceived { get; set; }
        public long ResendIntervalTicks { get; set; }
        public int MaxResendAttempts { get; set; }
        public long ResendTimeoutTicks { get; set; }
        public long HttpRetryTimeoutTicks { get; set; }
        public bool OverrideSendPort { get; set; }
        public long MinimumHttpRetryTicks { get; set; }
        public int MaximumHttpRetryAttempts { get; set; }
        public bool SignOutboundMdnIfOptional { get; set; }
        public string? Mdntext { get; set; }
        public bool EnableNrrforInboundEncodedMessages { get; set; }
        public bool EnableNrrforInboundDecodedMessages { get; set; }
        public bool EnableNrrforOutboundMdn { get; set; }
        public bool EnableNrrforOutboundEncodedMessages { get; set; }
        public bool EnableNrrforOutboundDecodedMessages { get; set; }
        public bool EnableNrrforInboundMdn { get; set; }
        public bool OverrideGroupSigningCertificate { get; set; }
        public string? CertificateName { get; set; }
        public string? CertificateThumbprint { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual ProtocolSettings Settings { get; set; } = null!;
    }
}
