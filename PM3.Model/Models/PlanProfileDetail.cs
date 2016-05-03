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

        // parents
        public virtual PlanProfile PlanProfile { get; set; }

        // children
        public virtual List<PlanProfileEvent> PlanProfileEvents { get; set; }
    }
}
