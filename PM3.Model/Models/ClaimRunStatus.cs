using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class ClaimRunStatus
    {
        public string ClaimRunStatusID { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<ClaimRun> ClaimRuns { get; set; }
    }
}
