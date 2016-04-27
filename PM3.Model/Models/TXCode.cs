using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class TXCode
    {
        public string TXCodeId { get; set; }
        public string Description { get; set; }
        public string TXTypeId { get; set; }
        public string PaymentFormId { get; set; }
        public string PaymentCategoryId { get; set; }

        // parents
        public virtual TXType TXType { get; set; }
        public virtual PaymentForm PaymentForm { get; set; }
        public virtual PaymentCategory PaymentCategory { get; set; }

        // children
        public virtual List<CARAction> CARActions { get; set; }

    }
}
