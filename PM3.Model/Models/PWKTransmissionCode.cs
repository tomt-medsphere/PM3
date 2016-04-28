using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class PWKTransmissionCode
    {
        public string PWKTransmissionCodeId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<Charge> Charges { get; set; }
    }
}
