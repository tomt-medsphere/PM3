using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class ClosingRun
    {
        public int ClosingRunId { get; set; }
        public DateTime ClosingRunDateTime { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }

        // parents
        public virtual User User { get; set; }

        // children
        public virtual List<TXBatch> TXBatches { get; set; }
        public virtual List<ChargeBatch> ChargeBatches { get; set; }
    }
}
