using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class TXCode
    {
        public string TXCodeId { get; set; }
        public string Description { get; set; }
        public string TXTypeID { get; set; }
        public string PaymentFormID { get; set; }
        public string PaymentCategoryID { get; set; }

        // parents
        public virtual TXType TXType { get; set; }
        public virtual PaymentForm PaymentForm { get; set; }
        public virtual PaymentCategory PaymentCategory { get; set; }
    }
}
