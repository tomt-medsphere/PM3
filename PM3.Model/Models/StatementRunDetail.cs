using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class StatementRunDetail
    {
        public int StatementRunDetailID { get; set; }
        public int StatementRunID { get; set; }
        public int BillingAccountID { get; set; }
        public string StatementData { get; set; }

        // parents
        public virtual StatementRun StatementRun { get; set; }
        public virtual BillingAccount BillingAccount { get; set; }
    }
}
