using System;

namespace PM3.Model.Models
{
    public class PrepError
    {
        public int PrepErrorId { get; set; }
        public int ChargeId { get; set; }
        public int? ChargeServiceId { get; set; }
        public int PrepRuleId { get; set; }
        public int? ChargeInsCoverageId { get; set; }
        public string ErrorNote { get; set; }
        public DateTime? CorrectedDateTime { get; set; }
        public string UserId { get; set; }
        public bool OnDemand { get; set; }

        // parents
        public virtual Charge Charge { get; set; }
        public virtual ChargeService ChargeService { get; set; }
        public virtual ChargeInsCoverage ChargeInsCoverage { get; set; }
        public virtual User User { get; set; }
        public virtual PrepRule PrepRule { get; set; }

    }
}
