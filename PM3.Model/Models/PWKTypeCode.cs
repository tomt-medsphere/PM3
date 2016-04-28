using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class PWKTypeCode
    {
        public string PWKTypeCodeId { get; set; }
        public string Description { get; set; }
       
        // children
        public virtual List<Charge> Charges { get; set; }
    }
}
