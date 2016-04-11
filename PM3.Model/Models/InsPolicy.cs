using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class InsPolicy
    {
        public int InsPolicyId { get; set; }
        public string InsPlanId { get; set; }
        public int SubscriberID { get; set; }
        public string PolicyNumber { get; set; }
        public string GroupNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Note { get; set; }
        public decimal CoPayAmount { get; set; }
        public string SubscriberMemberID { get; set; }
        public DateTime DateOfInjury { get; set; }
        public string AccidentCodeID { get; set; }
        public string AccidentStateID { get; set; }
        public string GroupName { get; set; }
        public string AltLastName { get; set; }
        public string AltFirstName { get; set; }
        public string AltMiddleName { get; set; }
        public string AltSuffixID { get; set; }
        public DateTime AltDOB { get; set; }

        // parents
        public virtual InsPlan InsPlan { get; set; }
        public virtual Person Subscriber { get; set;}
        public virtual AccidentCode AccidentCode { get; set; }
        public virtual USPSState AccidentState { get; set; }
        public virtual Suffix AltSuffix { get; set; }

    }
}
