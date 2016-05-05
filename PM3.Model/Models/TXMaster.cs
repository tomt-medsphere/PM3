using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class TXMaster
    {
        public int TXMasterId { get; set; }
        public int TXBatchId { get; set; }
        public DateTime EntryDateTime { get; set; }
        public decimal Amount { get; set; }
        public string Note { get; set; }
        public string InsPlanId { get; set; }
        public string ICN { get; set; }

        // parents
        public virtual TXBatch TXBatch { get; set; }
        
        // children
        public virtual List<TX> TXs { get; set; }
        public virtual List<TXMasterRARC> TXMasterRARC { get; set; }
    }
}
