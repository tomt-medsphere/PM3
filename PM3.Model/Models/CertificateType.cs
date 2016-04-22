using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class CertificateType
    {
        public string CertificateTypeId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<ChargeService> ChargeServices { get; set; }
        public virtual List<Service> Services { get; set; }
    }
}
