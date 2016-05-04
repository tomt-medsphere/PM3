using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class PostingPeriod
    {
        public string PostingPeriodId { get; set; }
        public string CreatedUserId { get; set; }
        public string ClosedUserId { get; set; }
        public DateTime ClosedDateTime { get; set; }

        // parents
        public virtual User CreatedUser { get; set; }
        public virtual User ClosedUser { get; set; }

        // children
        public virtual List<TXBatch> TXBatches { get; set; }
        public virtual List<ChargeBatch> ChargeBatches { get; set; }
    }
}