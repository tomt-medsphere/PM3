namespace PM3.Model.Models
{
    public class PrepRunPrepError
    {
        public int PrepRunPrepErrorId { get; set; }
        public int PrepRunId { get; set; }
        public int PrepRuleId { get; set; }
        public int ChargeId { get; set; }
        public int? ChargeServiceId { get; set; }
        public int? ChargeInsCoverageId { get; set; }
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
