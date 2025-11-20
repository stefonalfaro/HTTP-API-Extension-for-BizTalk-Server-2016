using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsItem
    {
        public BtsItem()
        {
            BtMapSpec = new HashSet<BtMapSpec>();
            BtsOrchestration = new HashSet<BtsOrchestration>();
        }

        public int Id { get; set; }
        public int AssemblyId { get; set; }
        public string? Namespace { get; set; }
        public string Name { get; set; } = null!;
        public string? FullName { get; set; }
        public string Type { get; set; } = null!;
        public byte? IsPipeline { get; set; }
        public Guid? Guid { get; set; }
        public byte? SchemaType { get; set; }
        public string? Description { get; set; }

        public virtual BtsAssembly Assembly { get; set; } = null!;
        public virtual ICollection<BtMapSpec> BtMapSpec { get; set; }
        public virtual ICollection<BtsOrchestration> BtsOrchestration { get; set; }
    }
}
