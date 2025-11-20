using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class XrefAppInstance
    {
        public int AppInstanceId { get; set; }
        public string AppInstance { get; set; } = null!;
        public int AppTypeId { get; set; }
    }
}
