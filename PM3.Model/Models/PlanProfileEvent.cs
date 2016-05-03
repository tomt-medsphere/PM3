using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class PlanProfileEvent
    {
        public int PlanProfileEventId { get; set; }
        public int PlanProfileId { get; set; }
        public int? PlanProfileDetailId { get; set; }

        // parents
        public virtual PlanProfile PlanProfile { get; set; }
        public virtual PlanProfileDetail PlanProfileDetail { get; set; }
    }
}
