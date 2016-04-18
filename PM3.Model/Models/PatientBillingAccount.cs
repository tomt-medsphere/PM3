using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class PatientBillingAccount
    {
        public int PatientBillingAccountID { get; set; }
        public int PatientID { get; set; }
        public int BillingAccountID { get; set; }
        public string RelationshipCodeID { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual Patient Patient { get; set; }
        public virtual BillingAccount BillingAccount { get; set; }
        public virtual RelationshipCode RelationshipCode { get; set; }
    }
}
