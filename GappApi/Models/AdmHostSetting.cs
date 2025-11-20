using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class AdmHostSetting
    {
        public int HostId { get; set; }
        public string PropertyName { get; set; } = null!;
        public string PropertyValue { get; set; } = null!;

        public virtual AdmHost Host { get; set; } = null!;
    }
}
