using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class X12protocolSettings
    {
        public X12protocolSettings()
        {
            X12envelopesOverrides = new HashSet<X12envelopesOverrides>();
            X12messageFilterList = new HashSet<X12messageFilterList>();
            X12schemaOverrides = new HashSet<X12schemaOverrides>();
            X12validationOverrides = new HashSet<X12validationOverrides>();
        }

        public int SettingsId { get; set; }
        public Guid? Ssoidentifier { get; set; }
        public short FilterListType { get; set; }
        public bool CreateEmptyXmlTagsForTrailingSeparators { get; set; }
        public bool MaskSecurityInfo { get; set; }
        public bool ConvertImpliedDecimal { get; set; }
        public bool PreserveInterchange { get; set; }
        public bool SuspendInterchangeOnError { get; set; }
        public bool UseDotAsDecimalIndicator { get; set; }
        public string TargetNamespace { get; set; } = null!;
        public int DataElementSeparator { get; set; }
        public int ComponentSeparator { get; set; }
        public int SegmentTerminator { get; set; }
        public short SegmentTerminatorSuffix { get; set; }
        public bool ReplaceSeparatorsInPayload { get; set; }
        public int ReplaceChar { get; set; }
        public bool NeedTechnicalAck { get; set; }
        public bool BatchTechnicalAck { get; set; }
        public bool NeedFunctionalAck { get; set; }
        public string? FunctionalAckVersion { get; set; }
        public bool BatchFunctionalAck { get; set; }
        public bool NeedImplementationAck { get; set; }
        public string? ImplementationAckVersion { get; set; }
        public bool BatchImplementationAck { get; set; }
        public bool GenerateLoopForValidMessagesInAck { get; set; }
        public bool RouteAcktoSendPipeline { get; set; }
        public bool GeneratePatAk901 { get; set; }
        public string? AcknowledgementControlNumberPrefix { get; set; }
        public string? AcknowledgementControlNumberSuffix { get; set; }
        public int AcknowledgementControlNumberLowerBound { get; set; }
        public int AcknowledgementControlNumberUpperBound { get; set; }
        public bool AcknowledgementControlNumberRollover { get; set; }
        public short CharacterSet { get; set; }
        public bool ValidateCharacterSet { get; set; }
        public bool ValidateEditypes { get; set; }
        public bool ValidateExtended { get; set; }
        public bool AllowLeadingAndTrailingSpacesAndZeroes { get; set; }
        public bool TrimLeadingAndTrailingSpacesAndZeroes { get; set; }
        public short TrailingSeparatorPolicy { get; set; }
        public bool CheckDuplicateInterchangeControlNumber { get; set; }
        public short InterchangeDuplicatesValidity { get; set; }
        public bool CheckDuplicateGroupControlNumber { get; set; }
        public bool CheckDuplicateTransactionSetControlNumber { get; set; }
        public int ControlStandardsId { get; set; }
        public bool UseControlStandardsIdasRepSep { get; set; }
        public string ControlVersionNumber { get; set; } = null!;
        public int InterchangeControlNumberLowerBound { get; set; }
        public int InterchangeControlNumberUpperBound { get; set; }
        public bool InterchangeControlNumberRollover { get; set; }
        public int GroupControlNumberLowerBound { get; set; }
        public int GroupControlNumberUpperBound { get; set; }
        public bool GroupControlNumberRollover { get; set; }
        public bool EnableDefaultGroupHeaders { get; set; }
        public string? FunctionalGroupId { get; set; }
        public short GroupDateFormat { get; set; }
        public short GroupTimeFormat { get; set; }
        public short GroupResponsibleAgencyCode { get; set; }
        public string? GroupHeaderVersion { get; set; }
        public string? SenderApplicationId { get; set; }
        public string? ReceiverApplicationId { get; set; }
        public bool TsapplyNewId { get; set; }
        public string? TscontrolNumberPrefix { get; set; }
        public string? TscontrolNumberSuffix { get; set; }
        public int TscontrolNumberLowerBound { get; set; }
        public int TscontrolNumberUpperBound { get; set; }
        public bool TscontrolNumberRollover { get; set; }
        public short UsageIndicator { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual ProtocolSettings Settings { get; set; } = null!;
        public virtual ICollection<X12envelopesOverrides> X12envelopesOverrides { get; set; }
        public virtual ICollection<X12messageFilterList> X12messageFilterList { get; set; }
        public virtual ICollection<X12schemaOverrides> X12schemaOverrides { get; set; }
        public virtual ICollection<X12validationOverrides> X12validationOverrides { get; set; }
    }
}
