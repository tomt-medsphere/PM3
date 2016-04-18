using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class ClaimFilingIndicator
    {
        public string ClaimFilingIndicatorID { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<InsPlan> InsPlans { get; set; }
    }
}
