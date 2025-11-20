using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class AdmHostInstanceSubServices
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string MonikerName { get; set; } = null!;
        public string ContextParam { get; set; } = null!;
        public int Type { get; set; }
        public Guid UniqueId { get; set; }
    }
}
