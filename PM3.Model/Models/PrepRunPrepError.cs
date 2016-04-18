using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class PrepRunPrepError
    {
        public int PrepRunPrepErrorID { get; set; }
        public int PrepRunID { get; set; }
        public int PrepRuleID { get; set; }
        public int ChargeID { get; set; }
        public int? ChargeServiceID { get; set; }
        public int? ChargeInsCoverageID { get; set; }
        public string Note { get; set; }
        public bool OnDemand { get; set; }

        // parents
        public virtual PrepRun PrepRun { get; set; }
        public virtual PrepRule PrepRule { get; set; }
        public virtual Charge Charge { get; set; }
        public virtual ChargeService ChargeService { get; set; }
        public virtual ChargeInsCoverage ChargeInsCoverage { get; set; }
    }
}
