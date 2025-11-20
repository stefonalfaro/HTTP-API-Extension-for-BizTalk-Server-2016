using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtfMessageSender
    {
        public string Identity { get; set; } = null!;
        public DateTime ExpiresAt { get; set; }
        public string Acknowledged { get; set; } = null!;
    }
}
