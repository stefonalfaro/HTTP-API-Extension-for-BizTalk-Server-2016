using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsmonInconsistancies
    {
        public string Dbserver { get; set; } = null!;
        public string Dbname { get; set; } = null!;
        public short NProblemCode { get; set; }
        public long NCount { get; set; }
    }
}
