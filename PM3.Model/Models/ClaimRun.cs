using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    class ClaimRun
    {
        public int ClaimRunID { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string UserID { get; set; }
        public string EDIPartnerID { get; set; }
        public string InsFormTypeID { get; set; }
        public string ClaimRunStatusID { get; set; }
        public DateTime SubmittedDateTime { get; set; }
        public DateTime AcknowledgedDateTime { get; set; }
        public int ClaimsProcessed { get; set; }
        public int ClaimsGenerated { get; set; }
        public string Note { get; set; }
        public string ClaimTransactionSet { get; set; }

        public virtual User User { get; set;}
        public virtual EDIPartner EDIPartner { get; set; }
        public virtual InsFormType InsFormType { get; set; }
        public virtual ClaimRunStatus ClaimRunStatus { get; set; }

    }
}
