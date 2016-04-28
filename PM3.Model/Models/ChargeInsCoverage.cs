using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class ChargeInsCoverage
    {
        public int ChargeInsCoverageId { get; set; }
        public int ChargeId { get; set; }
        public int InsCoverageId { get; set; }
        public int Sequence { get; set; }
        public bool Inactive { get; set; }

        // parents
        public virtual Charge Charge { get; set; }
        public virtual InsCoverage InsCoverage { get; set; }

        // children
        public virtual List<Charge> Charges { get; set; }
        public virtual List<PrepError> PrepErrors { get; set; }
        public virtual List<Claim> Claims { get; set; }
        public virtual List<PrepRequest> PrepRequests { get; set; }
        public virtual List<PrepRunPrepError> PrepRunPrepErrors { get; set; }
        public virtual List<TX> Tx { get; set; }

    }
}
