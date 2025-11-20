using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class Contact
    {
        public int ContactId { get; set; }
        public int AgreementId { get; set; }
        public string? Name { get; set; }
        public string? Company { get; set; }
        public string? JobTitle { get; set; }
        public string? Email { get; set; }
        public string? WebAddress { get; set; }
        public string? BusinessPhone { get; set; }
        public string? MobilePhone { get; set; }
        public string? Fax { get; set; }
        public string? Address { get; set; }
        public string? Notes { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual Agreement Agreement { get; set; } = null!;
    }
}
