using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class IdQualifier
    {
        public string IdQualifierId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<InsPlan> InsPlans { get; set; }
    }
}
