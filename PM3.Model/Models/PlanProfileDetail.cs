using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class PlanProfileDetail
    {
        public int PlanProfileDetailId { get; set; }
        public int PlanProfileId { get; set; }
        public string HCPCSId { get; set; }
        public string HCPCSModifierId { get; set; }
        public decimal Fee { get; set; }
        public decimal Allowed { get; set; }
        public string ChargeNote { get; set; }
        public string TXNote { get; set; }
        public string NPI { get; set; }

        // parents
        public virtual PlanProfile PlanProfile { get; set; }

        // children
        public virtual List<PlanProfileEvent> PlanProfileEvents { get; set; }
    }
}
