using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class InsFormType
    {
        public string InsFormTypeId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<Claim> Claims { get; set; }
        public virtual List<ClaimRun> ClaimRuns { get; set; }
    }
}
