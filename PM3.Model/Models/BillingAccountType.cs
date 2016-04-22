using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class BillingAccountType
    {
        public string BillingAccountTypeId { get; set; }
        public string Description { get; set; }
        public bool Billable { get; set; }
        public bool Dunning { get; set; }
        public bool Inactive { get; set; }

        // children
        public virtual List<BillingAccount> BillingAccounts { get; set; }

    }
}
