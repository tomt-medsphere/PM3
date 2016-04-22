using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class ChargeBatch
    {
        public int ChargeBatchId { get; set; }
        public string PostingPeriodId { get; set; }
        public string PracticeSiteId { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ClosedDateTime { get; set; }
        public bool ReadyToClose { get; set; }
        public int? ClosingRunId { get; set; }
        public string UserId { get; set; }

        // parents
        public virtual PostingPeriod PostingPeriod { get; set; }
        public virtual PracticeSite PracticeSite { get; set; }
        public virtual ClosingRun ClosingRun { get; set; }
        public virtual  User User { get; set; }

        // children
        public virtual List<Charge> Charges { get; set; }
    }
}
