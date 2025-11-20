using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class TddsSettings
    {
        public int? RefreshInterval { get; set; }
        public int? SqlCommandTimeout { get; set; }
        public int? SessionTimeout { get; set; }
        public string? EventLoggingInterval { get; set; }
        public int? RetryCount { get; set; }
        public int? ThreadPerSession { get; set; }
    }
}
