using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class USPSState
    {
        public string USPSStateId { get; set; }
        public string Name { get; set; }

        // children
        public virtual List<Charge> Charges { get; set; }
    }
}
