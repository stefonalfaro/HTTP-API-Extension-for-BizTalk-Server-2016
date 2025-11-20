using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class TddsServices
    {
        public Guid ServiceId { get; set; }
        public string ServerName { get; set; } = null!;
    }
}
