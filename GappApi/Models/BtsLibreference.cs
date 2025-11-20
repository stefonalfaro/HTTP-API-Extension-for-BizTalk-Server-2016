using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsLibreference
    {
        public int Idapp { get; set; }
        public int Idlib { get; set; }
        public string? RefName { get; set; }

        public virtual BtsAssembly IdappNavigation { get; set; } = null!;
        public virtual BtsAssembly IdlibNavigation { get; set; } = null!;
    }
}
