using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class InsPolicy
    {
        public int InsPolicyId { get; set; }
        public string InsPlanId { get; set; }
        public int SubscriberId { get; set; }
        public string PolicyNumber { get; set; }
        public string GroupNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Note { get; set; }
        public decimal CoPayAmount { get; set; }
        public string SubscriberMemberId { get; set; }
        public DateTime? DateOfInjury { get; set; }
        public string AccidentCodeId { get; set; }
        public string AccidentStateId { get; set; }
        public string GroupName { get; set; }
        public string AltSubLastName { get; set; }
        public string AltSubFirstName { get; set; }
        public string AltSubMiddleName { get; set; }
        public string AltSubSuffixId { get; set; }
        public DateTime? AltSubDOB { get; set; }

        // parents
        public virtual InsPlan InsPlan { get; set; }
        public virtual Person Subscriber { get; set;}
        public virtual AccidentCode AccidentCode { get; set; }
        public virtual USPSState AccidentState { get; set; }
        public virtual Suffix AltSuffix { get; set; }

        // children
        public virtual List<InsCoverage> InsCoverages { get; set; }
        public virtual List<InsPolicyAllowedDX> InsPolicyAllowedDXs { get; set; }

    }
}
