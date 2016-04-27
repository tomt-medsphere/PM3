using System;

namespace PM3.Model.Models
{
    public class TXBatch
    {
        public int TXBatchId { get; set; }
        public string TXCodeId { get; set; }
        public string Description { get; set; }
        public string InsPlanId { get; set; }
        public DateTime AdjudicationDate { get; set; }
        public string PayerReference { get; set; }
        public decimal Amount { get; set; }
        public DateTime DepositDate { get; set; }
        public bool ReadyToClose { get; set; }
        public DateTime ClosedDateTime { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string UserId { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string PaymentFormId { get; set; }
        public string PracticeSiteId { get; set; }
        public string ClosingRunId { get; set; }
        public string PostingPeriodId { get; set; }

        // parents
        public virtual TXCode TXCode { get; set; }
        public virtual InsPlan InsPlan { get; set; }
        public virtual User User { get; set; }
        public virtual PaymentForm PaymentForm { get; set;}
        public virtual PracticeSite PracticeSite { get; set; }
        public virtual ClosingRun ClosingRun { get; set; }
        public virtual PostingPeriod PostingPeriod { get; set; }
    }
}
