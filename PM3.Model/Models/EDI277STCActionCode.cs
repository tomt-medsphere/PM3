using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class EDI277STCActionCode
    {
        public string EDI277STCActionCodeId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<EDI277STCAction> EDI277STCActions { get; set; }
    }
}
