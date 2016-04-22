using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class ClaimRun
    {
        public int ClaimRunId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string UserId { get; set; }
        public string EDIPartnerId { get; set; }
        public string InsFormTypeId { get; set; }
        public string ClaimRunStatusId { get; set; }
        public DateTime? SubmittedDateTime { get; set; }
        public DateTime? AcknowledgedDateTime { get; set; }
        public int ClaimsProcessed { get; set; }
        public int ClaimsGenerated { get; set; }
        public string Note { get; set; }
        public string ClaimTransactionSet { get; set; }

        // parents
        public virtual User User { get; set;}
        public virtual EDIPartner EDIPartner { get; set; }
        public virtual InsFormType InsFormType { get; set; }
        public virtual ClaimRunStatus ClaimRunStatus { get; set; }

        // children
        public virtual List<EDI277> EDI277 { get; set; }
        public virtual List<EDISessionStep> EDISessionSteps { get; set; }
        public virtual List<Claim> Claims { get; set; }
    }
}
