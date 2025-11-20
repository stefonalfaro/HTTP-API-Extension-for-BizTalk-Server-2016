using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsPartySendport
    {
        public int NId { get; set; }
        public int NPartyId { get; set; }
        public int NSendPortId { get; set; }
        public int NSequence { get; set; }
        public DateTime DateModified { get; set; }
    }
}
