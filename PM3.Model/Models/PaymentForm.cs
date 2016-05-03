using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class PaymentForm
    {
        public string PaymentFormId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<TXCode> TXCodes { get; set; }
        public virtual List<TXBatch> TXBatches { get; set; }
        public virtual List<TX> TXs { get; set; }
    }
}
