using System;

namespace PM3.Model.Models
{
    public class InsPlanCARAction
    {
        public int InsPlanCARActionId { get; set; }
        public string CARId { get; set; }
        public string InsPlanId { get; set; }
        public string ShortDescription { get; set; }
        public bool SetReviewStatus { get; set; }
        public bool CreateTxNote { get; set; }
        public string TxCodeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // parents
        public virtual CARCode CARCode { get; set; }
        public virtual InsPlan InsPlan { get; set; }
    }
}
