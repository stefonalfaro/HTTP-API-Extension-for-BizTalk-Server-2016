using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class EdifactprotocolSettings
    {
        public EdifactprotocolSettings()
        {
            EdifactenvelopeOverrides = new HashSet<EdifactenvelopeOverrides>();
            EdifactmessageFilterList = new HashSet<EdifactmessageFilterList>();
            EdifactschemaOverrides = new HashSet<EdifactschemaOverrides>();
            EdifactvalidationOverrides = new HashSet<EdifactvalidationOverrides>();
        }

        public int SettingsId { get; set; }
        public bool CreateEmptyXmlTagsForTrailingSeparators { get; set; }
        public bool MaskSecurityInfo { get; set; }
        public bool PreserveInterchange { get; set; }
        public bool SuspendInterchangeOnError { get; set; }
        public bool UseDotAsDecimalIndicator { get; set; }
        public string TargetNamespace { get; set; } = null!;
        public short MessageFilterType { get; set; }
        public short CharacterSet { get; set; }
        public short ProtocolVersion { get; set; }
        public string? ServiceCodeListDirectoryVersion { get; set; }
        public string? CharacterEncoding { get; set; }
        public int DataElementSeparator { get; set; }
        public int ComponentSeparator { get; set; }
        public int SegmentTerminator { get; set; }
        public short DecimalPointIndicator { get; set; }
        public int ReleaseIndicator { get; set; }
        public int RepetitionSeparator { get; set; }
        public short SegmentTerminatorSuffix { get; set; }
        public bool EnforceCharacterSet { get; set; }
        public bool ValidateEditypes { get; set; }
        public bool ValidateXsdtypes { get; set; }
        public bool TrimLeadingAndTrailingSpacesAndZeroes { get; set; }
        public bool AllowLeadingAndTrailingSpacesAndZeroes { get; set; }
        public short TrailingSeparatorPolicy { get; set; }
        public bool CheckDuplicateInterchangeControlNumber { get; set; }
        public short InterchangeDuplicatesValidity { get; set; }
        public bool CheckDuplicateGroupControlNumber { get; set; }
        public bool CheckDuplicateTransactionSetControlNumber { get; set; }
        public bool NeedTechnicalAck { get; set; }
        public bool BatchTechnicalAck { get; set; }
        public bool NeedFunctionalAck { get; set; }
        public bool BatchFunctionalAck { get; set; }
        public bool GenerateLoopForValidMessagesInAck { get; set; }
        public bool RouteAcktoSendPipeline { get; set; }
        public string? ProcessingPriorityCode { get; set; }
        public string? CommunicationAgreementId { get; set; }
        public bool ApplyDelimiterStringAdvice { get; set; }
        public string? ApplicationReferenceId { get; set; }
        public long InterchangeControlNumberLowerBound { get; set; }
        public long InterchangeControlNumberUpperBound { get; set; }
        public bool InterchangeControlNumberRollover { get; set; }
        public string? InterchangeControlNumberPrefix { get; set; }
        public string? InterchangeControlNumberSuffix { get; set; }
        public string? SenderReverseRoutingAddress { get; set; }
        public string? ReceiverReverseRoutingAddress { get; set; }
        public string? SenderInternalIdentification { get; set; }
        public string? SenderInternalSubIdentification { get; set; }
        public string? ReceiverInternalIdentification { get; set; }
        public string? ReceiverInternalSubIdentification { get; set; }
        public Guid? Ssoidentifier { get; set; }
        public bool CreateGroupingSegments { get; set; }
        public string? GroupApplicationSenderId { get; set; }
        public string? GroupApplicationSenderQualifier { get; set; }
        public string? GroupApplicationReceiverId { get; set; }
        public string? GroupApplicationReceiverQualifier { get; set; }
        public bool EnableDefaultGroupHeaders { get; set; }
        public string? FunctionalGroupId { get; set; }
        public string? GroupControllingAgencyCode { get; set; }
        public string? GroupMessageVersion { get; set; }
        public string? GroupMessageRelease { get; set; }
        public string? GroupAssociationAssignedCode { get; set; }
        public long GroupControlNumberLowerBound { get; set; }
        public long GroupControlNumberUpperBound { get; set; }
        public bool GroupControlNumberRollover { get; set; }
        public string? GroupControlNumberPrefix { get; set; }
        public string? GroupControlNumberSuffix { get; set; }
        public bool TsapplyNewId { get; set; }
        public string? TscontrolNumberPrefix { get; set; }
        public string? TscontrolNumberSuffix { get; set; }
        public long TscontrolNumberLowerBound { get; set; }
        public long TscontrolNumberUpperBound { get; set; }
        public bool TscontrolNumberRollover { get; set; }
        public string? AcknowledgementControlNumberPrefix { get; set; }
        public string? AcknowledgementControlNumberSuffix { get; set; }
        public long AcknowledgementControlNumberLowerBound { get; set; }
        public long AcknowledgementControlNumberUpperBound { get; set; }
        public bool AcknowledgementControlNumberRollover { get; set; }
        public bool IsTestInterchange { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual ProtocolSettings Settings { get; set; } = null!;
        public virtual ICollection<EdifactenvelopeOverrides> EdifactenvelopeOverrides { get; set; }
        public virtual ICollection<EdifactmessageFilterList> EdifactmessageFilterList { get; set; }
        public virtual ICollection<EdifactschemaOverrides> EdifactschemaOverrides { get; set; }
        public virtual ICollection<EdifactvalidationOverrides> EdifactvalidationOverrides { get; set; }
    }
}
