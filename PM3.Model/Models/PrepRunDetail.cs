using System;

namespace PM3.Model.Models
{
    public class PrepRunDetail
    {
        public int PrepRunDetailId { get; set; }
        public int PrepRunId { get; set; }
        public int ChargeId { get; set; }
        public string InsPlanId { get; set; }
        public DateTime FirstDateOfService { get; set; }
        public decimal TotalFee { get; set; }
        public decimal BilledFee { get; set; }
        public string PassedPrep { get; set; }
        public string EDIPartnerId { get; set; }
        public string InsFormTypeId { get; set; }

        // parents
        public virtual PrepRun PrepRun { get; set; }
        public virtual Charge Charge { get; set; }
        public virtual InsPlan InsPlan { get; set; }
        public virtual EDIPartner EDIPartner { get; set; }
        public virtual InsFormType InsFormType { get; set; }
    }
}
