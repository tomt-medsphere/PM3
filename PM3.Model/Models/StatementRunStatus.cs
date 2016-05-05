using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class StatementRunStatus
    {
        public string StatementRunStatusId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List <StatementRun> StatementRuns { get; set; }
    }
}
