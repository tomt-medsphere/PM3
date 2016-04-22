using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class TxMaster
    {
        public int TxMasterId { get; set; }
        public int TxBatchId { get; set; }
        public DateTime EntryDateTime { get; set; }
        public decimal Amount { get; set; }
        public string Note { get; set; }
        public string InsPlanId { get; set; }
        public string Icn { get; set; }

        // parents
        public virtual TxBatch TxBatch { get; set; }
        
        // children
        public virtual List<Tx> Tx { get; set; }
        public virtual List<TxMasterRARC> TxMasterRARC { get; set; }
    }
}
