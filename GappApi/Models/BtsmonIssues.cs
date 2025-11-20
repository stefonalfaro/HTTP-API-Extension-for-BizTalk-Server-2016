using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsmonIssues
    {
        public short NProblemCode { get; set; }
        public string NvcProblemDescription { get; set; } = null!;
    }
}
