using System;

namespace PM3.Model.Models
{
    public class CARAction
    {
        public int CARActionId { get; set; }
        public string CarCodeId { get; set; }
        public string ShortDescription { get; set; }
        public bool SetReview { get; set; }
        public bool CreateTxNote { get; set; }
        public string TxCodeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // parents
        public virtual Car CarCodes { get; set; }
        public virtual TxCode TxCodes { get; set; }
    }
}
