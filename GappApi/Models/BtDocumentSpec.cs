using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtDocumentSpec
    {
        public Guid Id { get; set; }
        public int Itemid { get; set; }
        public int Assemblyid { get; set; }
        public Guid? Shareid { get; set; }
        public string Msgtype { get; set; } = null!;
        public DateTime DateModified { get; set; }
        public string? BodyXpath { get; set; }
        public bool IsPropertySchema { get; set; }
        public bool IsMultiroot { get; set; }
        public string? ClrNamespace { get; set; }
        public string? ClrTypename { get; set; }
        public string? ClrAssemblyname { get; set; }
        public string? SchemaRootName { get; set; }
        public string? XsdType { get; set; }
        public bool IsTracked { get; set; }
        public string? DocspecName { get; set; }
        public string? PropertyClrClassFqn { get; set; }
        public string? SchemaRootClrFqn { get; set; }
        public bool IsFlat { get; set; }
        public string? PropertyClrClass { get; set; }
        public string? Description { get; set; }

        public virtual BtsAssembly Assembly { get; set; } = null!;
        public virtual BtsItem Item { get; set; } = null!;
        public virtual BtXmlshare? Share { get; set; }
    }
}
