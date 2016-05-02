using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class PlanProfile
    {
        public int PlanProfileId { get; set; }
        public string InsPlanId { get; set; }
        public string InsPlanGroupId { get; set; }
        public DateTime DOSStart { get; set; }
        public DateTime?  DOSEnd { get; set; }
        public string AutoUpdate { get; set; }
        public string EventAction { get; set; }
        public bool OverrideFees { get; set; }
        public bool NPITracking { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
        
        // parents
        public virtual InsPlan InsPlan { get; set; }
        public virtual InsPlanGroup InsPlanGroup { get; set; }

        // children
        //public virtual List<PlanProfileDetail> PlanProfileDetails { get; set; }
    }
}
