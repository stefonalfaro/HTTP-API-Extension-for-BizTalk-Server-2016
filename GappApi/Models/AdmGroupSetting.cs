using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class AdmGroupSetting
    {
        public int GroupId { get; set; }
        public string PropertyName { get; set; } = null!;
        public string PropertyValue { get; set; } = null!;

        public virtual AdmGroup Group { get; set; } = null!;
    }
}
