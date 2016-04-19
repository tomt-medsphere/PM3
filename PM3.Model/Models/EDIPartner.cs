using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class EDIPartner
    {
        public string EDIPartnerID { get; set; }
        public string Name { get; set; }
        public string SubmitterID { get; set; }
        public string ReceiverID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string DUN { get; set; }
        public bool Testing { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string SiteID { get; set; }
        public string X12Version { get; set; }
        public string URL { get; set; }
        public string Note { get; set; }
        public bool ClaimsService { get; set; }
        public bool ERAService { get; set; }
        public bool EligibilityService { get; set; }
        public bool OtherService { get; set; }
        public bool Inactive { get; set; }

        // parents
        public virtual List<EDISession> EDISessions { get; set; }
        public virtual List<Claim> Claims { get; set; }
        public virtual List<PrepRunDetail> PrepRunDetails { get; set; }
        public virtual List<ClaimRun> ClaimRuns { get; set; }
    }
}
