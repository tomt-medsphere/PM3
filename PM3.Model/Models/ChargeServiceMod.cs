using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class ChargeServiceMod
    {
        public int ChargeServiceModID { get; set; }
        public int ChargeServiceID { get; set; }
        public string HCPCSModifierID { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual ChargeService ChargeService { get; set;}
        public virtual HCPCSModifier HCPCSModifier { get; set; }
    }
}
