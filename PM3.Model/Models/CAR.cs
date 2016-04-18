using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class CAR
    {
        public string CARID { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        // children
        public virtual List<CARAction> CARActions { get; set; }
        public virtual List<InsPlanCARAction> InsPlanCARActions { get; set; }
        public virtual List<TX> TX { get; set; }
        public virtual List<TXCAS> TXCAS { get; set; }
    }
}
