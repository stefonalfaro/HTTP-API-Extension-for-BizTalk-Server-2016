using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class AdmHostInstanceSetting
    {
        public int HostInstanceId { get; set; }
        public string PropertyName { get; set; } = null!;
        public string PropertyValue { get; set; } = null!;

        public virtual AdmHostInstance HostInstance { get; set; } = null!;
    }
}
