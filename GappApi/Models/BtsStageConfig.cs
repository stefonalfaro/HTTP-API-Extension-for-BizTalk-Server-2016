using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsStageConfig
    {
        public int StageId { get; set; }
        public int CompId { get; set; }
        public short Sequence { get; set; }
    }
}
