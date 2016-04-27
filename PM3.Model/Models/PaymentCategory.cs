using PM3.Model.Models;
using System.Collections.Generic;

namespace PM3.Model
{
    public class PaymentCategory
    {
        public string PaymentCategoryId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<TXCode> TxCodes { get; set; }
    }
}
