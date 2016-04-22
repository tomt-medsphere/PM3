using System;

namespace PM3.Model.Models
{
    public class StatementRun
    {
        public int StatementRunId { get; set; }
        public DateTime StatementRunDateTime { get; set; }
        public bool EDI { get; set; }
        public string StatementRunStatusId { get; set; }
        public string UserId { get; set; }

        // parents
        public virtual StatementRunStatus StatementRunStatus { get; set; }
        public virtual User User { get; set; }
    }
}
