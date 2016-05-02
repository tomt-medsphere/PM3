using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class InsPlanGroup
    {
        public string InsPlanGroupId { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public bool Inactive { get; set; }

        // children
        public virtual List<InsPlan> InsPlans { get; set; }
        public virtual List<PlanProfile> PlanProfiles { get; set; }
    }
}
