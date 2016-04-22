using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class ClaimRunStatus
    {
        public string ClaimRunStatusId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<ClaimRun> ClaimRuns { get; set; }
    }
}
