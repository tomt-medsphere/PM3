using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class TXCAS
    {
        public int TXCASID { get; set; }
        public int TXID { get; set; }
        public string CAGCodeID { get; set; }
        public string CARCodeID { get; set; }
        public decimal Amount { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual TX TX { get; set; }
        public virtual CAGCode CAGCode { get; set; }
        public virtual CAR CARCode { get; set; }
    }
}
