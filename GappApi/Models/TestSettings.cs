using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class TestSettings
    {
        public int Id { get; set; }
        public string SendSetting { get; set; } = null!;
        public string ReceiveSetting { get; set; } = null!;

        public virtual ProtocolSettings IdNavigation { get; set; } = null!;
    }
}
