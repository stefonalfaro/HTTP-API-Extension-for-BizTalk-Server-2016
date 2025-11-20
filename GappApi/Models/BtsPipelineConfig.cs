using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsPipelineConfig
    {
        public int PipelineId { get; set; }
        public int StageId { get; set; }
        public short Sequence { get; set; }
    }
}
