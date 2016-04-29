using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class HCPCS
    {
        public string HCPCSId { get; set; }

        // children
        public virtual List<HCPCSRVU> HCPCSRVUs { get; set; }
        public virtual List<Service> HCPCSServices { get; set; }
        public virtual List<Service> HCPCSL2Services { get; set; }
        public virtual List<TX> TXs { get; set; }
        public virtual List<ChargeService> HCPCSChargeServices { get; set; }
        public virtual List<ChargeService> HCPCSL2ChargeServices { get; set; }

    }
}
