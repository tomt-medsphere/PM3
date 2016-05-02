using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class ICD
    {
        public int ICDId { get; set; }
        public string ICDCode { get; set; }
        public string System { get; set; }
        public string Version { get; set; }
        public int Year { get; set; }
        public bool FurtherSpecified { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string MediumDescription { get; set; }

        // children
        public virtual List<InsPolicyAllowedDX> InsPolicyAllowedDxs { get; set; }
        public virtual List<ChargeICD> ChargeICDs { get; set; }
        public virtual List<ChargeServiceICD> ChargeServiceICDs { get; set; }
    }
}
