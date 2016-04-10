using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    class Claim
    {
        public int ClaimID { get; set; }
        public int PrepRunID { get; set; }
        public int ChargeID { get; set; }
        public int ChargeInsCoverageID { get; set; }
        public string InsPlanID { get; set; }
        public string EDIPartnerID { get; set; }
        public string InsFormTypeID { get; set; }
        public int ClaimRunID { get; set; }
        public string BillingProviderTIN { get; set; }
        public string BillingProviderNPI { get; set; }
        public decimal TotalFee { get; set; }
        public decimal BilledFee { get; set; }
        public bool Suppress { get; set; }
        public DateTime ClaimStatusDate { get; set; }
        public string ClaimActionCode { get; set; }
        public string ClaimICN { get; set; }

        public virtual Charge Charge { set; get; }
        public virtual PrepRun PrepRun { get; set; }
        public virtual ChargeInsCoverage ClaimInsCoverage { get; set; }
        public virtual EDIPartner EDIPartner { get; set; }
        public virtual InsFormType InsFormType { get; set; }
        public virtual InsPlan InsPlan { get; set; }
    }
}
