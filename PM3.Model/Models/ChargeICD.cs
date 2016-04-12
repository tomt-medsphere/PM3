using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class ChargeICD
    {
        public int ChargeICDID { get; set; }
        public int ChargeID { get; set; }
        public string ICDID { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual Charge Charge { get; set; }
        public virtual ICD ICD { get; set; }
    }
}
