using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class TXBatch
    {
        public int TXBatchID { get; set; }
        public string TXCodeID { get; set; }
        public string Description { get; set; }
        public string InsPlanID { get; set; }
        public DateTime AdjudicationDate { get; set; }
        public string PayerReference { get; set; }
        public decimal Amount { get; set; }
        public DateTime DepositDate { get; set; }
        public bool ReadyToClose { get; set; }
        public DateTime ClosedDateTime { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string UserID { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string PaymentFormID { get; set; }
        public string PracticeSiteID { get; set; }
        public string ClosingRunID { get; set; }
        public string PostingPeriodID { get; set; }

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
