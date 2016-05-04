using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class HCPCSModifier
    {
        public string HCPCSModifierId { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        // children
        public virtual List<TXHCPCSModifier> TXHCPCSModifiers { get; set; }
        public virtual List<ServiceHCPCSModifier> ServiceHCPCSModifiers { get; set; }
        public virtual List<ChargeServiceMod> ChargeServiceMods { get; set; }
        public virtual List<PlanProfileEvent> PlanProfileEvents { get; set; }
    }
}
