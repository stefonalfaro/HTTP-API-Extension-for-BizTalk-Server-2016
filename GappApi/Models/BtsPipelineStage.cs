using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsPipelineStage
    {
        public int Id { get; set; }
        public Guid Category { get; set; }
        public string Name { get; set; } = null!;
        public int ExecOptions { get; set; }
    }
}
