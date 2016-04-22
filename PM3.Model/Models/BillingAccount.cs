using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class BillingAccount
    {
        public int BillingAccountId { get; set; }
        public int GuarantorId { get; set; }
        public string BillingAccountTypeId { get; set; }
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
