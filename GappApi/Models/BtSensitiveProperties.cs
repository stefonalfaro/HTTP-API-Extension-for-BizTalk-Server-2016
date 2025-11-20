using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtSensitiveProperties
    {
        public int Id { get; set; }
        public string? Msgtype { get; set; }
        public int Assemblyid { get; set; }

        public virtual BtsAssembly Assembly { get; set; } = null!;
    }
}
