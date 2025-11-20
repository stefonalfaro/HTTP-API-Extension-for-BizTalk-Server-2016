using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsComponent
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Version { get; set; } = null!;
        public Guid? ClsId { get; set; }
        public string? TypeName { get; set; }
        public string? AssemblyPath { get; set; }
        public string? Description { get; set; }
        public byte[]? CustomData { get; set; }
    }
}
