using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class EDI835
    {
        public int EDI835ID { get; set; }
        public int? EDIInboxID { get; set; }
        public int? TXBatchID { get; set; }
        public string SenderID { get; set; }
        public string ReceiverID { get; set; }
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
        public string EDI835txt { get; set; }
        public string SegmentDelimiter { get; set; }
        public string ElementDelimiter { get; set; }
        public string SubElementDelimiter { get; set; }
        public string PayerID { get; set; }

        // parents
        public virtual EDIInbox EDIInbox { get; set; }
        public virtual TXBatch TXBatch { get; set; }

        // children
        public virtual List<EDI835Log> EDI835Log { get; set; }
    }
}
