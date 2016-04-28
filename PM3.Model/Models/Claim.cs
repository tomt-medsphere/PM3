using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class Claim
    {
        public int ClaimId { get; set; }
        public int ChargeId { get; set; }
        public int PrepRunId { get; set; }
        public int? ChargeInsCoverageId { get; set; }
        public string InsPlanId { get; set; }
        public string EDIPartnerId { get; set; }
        public string InsFormTypeId { get; set; }
        public int? ClaimRunId { get; set; }
        public string BillingProviderTIN { get; set; }
        public string BillingProviderNPI { get; set; }
        public decimal TotalFee { get; set; }
        public decimal BilledFee { get; set; }
        public bool Suppress { get; set; }
        public DateTime? ClaimStatusDate { get; set; }
        public string ClaimActionCode { get; set; }
        public string ClaimICN { get; set; }

        // parents
        public virtual Charge Charge { set; get; }
        public virtual PrepRun PrepRun { get; set; }
        public virtual ChargeInsCoverage ChargeInsCoverage { get; set; }
        public virtual InsPlan InsPlan { get; set; }
        public virtual EDIPartner EDIPartner { get; set; }
        public virtual InsFormType InsFormType { get; set; }
        public virtual ClaimRun ClaimRun { get; set; }

        // children
        public virtual List<EDI277STC> EDI277STCs { get; set; }
    }
}
