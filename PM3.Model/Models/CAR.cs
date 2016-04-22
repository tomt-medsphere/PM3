using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class Car
    {
        public string CARId { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        // children
        public virtual List<CARAction> CARActions { get; set; }
        public virtual List<InsPlanCARAction> InsPlanCARActions { get; set; }
        public virtual List<Tx> Tx { get; set; }
        public virtual List<TxCAS> TxCAS { get; set; }
    }
}
