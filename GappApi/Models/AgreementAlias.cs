using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class AgreementAlias
    {
        public int Id { get; set; }
        public int OnewayAgreementId { get; set; }
        public string Protocol { get; set; } = null!;
        public string Key { get; set; } = null!;
        public string Value { get; set; } = null!;
        public byte[] Version { get; set; } = null!;

        public virtual OnewayAgreement OnewayAgreement { get; set; } = null!;
    }
}
