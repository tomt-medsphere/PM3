using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class TXHCPCSModifier
    {
        public int TXHCPCSModifierID { get; set; }
        public int TXID { get; set; }
        public string HCPCSModifierID { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual TX TX { get; set; }
        public virtual HCPCSModifier HCPCSModifier { get; set; }
    }
}
