using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class ChargeServiceICD
    {
        public int ChargeServiceICDID { get; set; }
        public int ChargeServiceID { get; set; }
        public string ICDID { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual ICD ICD { get; set; }
        public virtual ChargeService ChargeService { get; set; }
    }
}
