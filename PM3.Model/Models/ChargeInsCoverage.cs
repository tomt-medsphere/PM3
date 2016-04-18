using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class ChargeInsCoverage
    {
        public int ChargeInsCoverageID { get; set; }
        public int ChargeID { get; set; }
        public int InscoverageID { get; set; }
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
        public virtual List<TX> TX { get; set; }

    }
}
