using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class CdcEthnicity
    {
        public string CdcEthnicityId { get; set; }
        public string HCode { get; set; }
        public string Description { get; set; }
        public string MuCode { get; set; }

        // children
        public virtual List<PersonEthnicity> PersonEthnicities { get; set; }
    }
}
