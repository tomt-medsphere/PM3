using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class BillingAccountType
    {
        public string BillingAccountTypeID { get; set; }
        public string Description { get; set; }
        public bool Billable { get; set; }
        public bool Dunning { get; set; }
        public bool Inactive { get; set; }
    }
}
