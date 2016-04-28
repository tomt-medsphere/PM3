using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class EDI835
    {
        public int EDI835Id { get; set; }
        public int? EDIInboxId { get; set; }
        public int? TXBatchId { get; set; }
        public string SenderId { get; set; }
        public string ReceiverId { get; set; }
        public DateTime? InterchangeDateTime { get; set; }
        public string InterchangeICN { get; set; }
        public DateTime? GroupDateTime { get; set; }
        public string GroupICN { get; set; }
        public string TransactionSetICN { get; set; }
        public string X12Version { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string PaymentTraceNumber { get; set; }
        public string EDI835Text { get; set; }
        public string SegmentDelimiter { get; set; }
        public string ElementDelimiter { get; set; }
        public string SubElementDelimiter { get; set; }
        public string PayerId { get; set; }

        // parents
        public virtual EDIInbox EDIInbox { get; set; }
        public virtual TXBatch TxBatch { get; set; }

        // children
        public virtual List<EDI835Log> EDI835Log { get; set; }
    }
}
