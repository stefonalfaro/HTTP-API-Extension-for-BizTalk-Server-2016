using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    /// <summary>
    /// BizTalk framework pipeline component message tracking table for receiver
    /// </summary>
    public partial class BtfMessageReceiver
    {
        public string Identity { get; set; } = null!;
        public DateTime ExpiresAt { get; set; }
    }
}
