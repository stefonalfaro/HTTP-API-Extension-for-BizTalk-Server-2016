using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class AdmAdapterAlias
    {
        public int Id { get; set; }
        public int AdapterId { get; set; }
        public string AliasValue { get; set; } = null!;
    }
}
