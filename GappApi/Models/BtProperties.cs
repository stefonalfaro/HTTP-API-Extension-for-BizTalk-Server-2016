using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtProperties
    {
        public Guid Id { get; set; }
        public Guid PropSchemaId { get; set; }
        public int? NAssemblyId { get; set; }
        public string Msgtype { get; set; } = null!;
        public string Namespace { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Xpath { get; set; }
        public bool IsTracked { get; set; }
        public int Itemid { get; set; }

        public virtual BtsAssembly? NAssembly { get; set; }
    }
}
