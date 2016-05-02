using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class MSPType
    {
        public string MSPTypeId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<InsPlan> InsPlans { get; set; }
    }
}
