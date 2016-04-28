using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class ICD
    {
        public int ICDId { get; set; }
        public string ICDCode { get; set; }
        public int Year { get; set; }
        public string System { get; set; }
        public string Version { get; set; }
        public bool FurtherSpecified { get; set; }

        // children
        public virtual List<ChargeICD> ChargeICDs { get; set; }
        public virtual List<ChargeServiceICD> ChargeServiceICDs { get; set; }
    }
}
