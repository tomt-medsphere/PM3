using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class ServiceHCPCSModifier
    {
        public int ServiceHCPCSModifierID { get; set; }
        public string ServiceID { get; set; }
        public string HCPCSModifierID { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual Service Service { get; set; }
        public virtual HCPCSModifier HCPCSModifier { get; set; }
    }
}
