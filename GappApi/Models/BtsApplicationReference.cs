using System;
using System.Collections.Generic;

namespace GappApi.Models
{
    public partial class BtsApplicationReference
    {
        public int NId { get; set; }
        public int? NApplicationId { get; set; }
        public int? NReferencedApplicationId { get; set; }

        public virtual BtsApplication? NApplication { get; set; }
        public virtual BtsApplication? NReferencedApplication { get; set; }
    }
}
