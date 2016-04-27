using System;

namespace PM3.Model.Models
{
    public class CARAction
    {
        public int CARActionId { get; set; }
        public string CARCodeId { get; set; }
        public string ShortDescription { get; set; }
        public bool SetReview { get; set; }
        public bool CreateTXNote { get; set; }
        public string TXCodeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        // parents
        public virtual CARCode CARCode { get; set; }
        public virtual TXCode TXCode { get; set; }
    }
}
