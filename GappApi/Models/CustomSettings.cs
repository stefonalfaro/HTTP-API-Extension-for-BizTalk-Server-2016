using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class CustomSettings
    {
        public int Id { get; set; }
        public byte[]? Blob { get; set; }
        public bool Modified { get; set; }
        public byte[] Version { get; set; } = null!;
    }
}
