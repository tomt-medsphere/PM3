using PM3.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class BillingAccount
    {
        public int BillingAccountID { get; set; }
        public int GuarantorID { get; set; }
        public string BillingAccountTypeID { get; set; }
        public DateTime BillingAccountTypeDate { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }

        public virtual Person Guarantor { get; set; }
        public virtual BillingAccountType BillingAccountType {get; set;}

    }
}
