using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class ChargeServiceStatus
    {
        public string ChargeServiceStatusId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<ChargeService> ChargeServices { get; set; }
    }
}
