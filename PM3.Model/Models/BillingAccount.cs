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

        // parents
        public virtual Person Guarantor { get; set; }
        public virtual BillingAccountType BillingAccountType {get; set;}

        // children
        public virtual List<PatientBillingAccount> PatientBillingAccounts { get; set; }
        public virtual List<Charge> Charges { get; set; }
        public virtual List<StatementRunDetail> StatementRunDetails { get; set; }
        public virtual List<ChargeService> ChargeServices { get; set; }

    }
}
