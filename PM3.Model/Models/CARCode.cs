using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class CARCode
    {
        public string CARCodeId { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        // children
        public virtual List<CARAction> CARActions { get; set; }
        public virtual List<InsPlanCARAction> InsPlanCARActions { get; set; }
        public virtual List<TX> TXs { get; set; }
        public virtual List<TXCAS> TXCASs { get; set; }
    }
}
