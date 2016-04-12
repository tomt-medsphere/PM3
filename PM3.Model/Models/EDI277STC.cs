using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class EDI277STC
    {
        public int EDI277STCID { get; set; }
        public int EDI277ID { get; set; }
        public int ClaimID { get; set; }
        public int ChargeID { get; set; }
        public int ChargeServiceID { get; set; }
        public string STCSegment { get; set; }
        public string REF1K { get; set; }

        // parent
        public virtual EDI277 EDI277 { get; set; }
        public virtual Claim Claim { get; set; }
        public virtual Charge Charge { get; set; }
        public virtual ChargeService ChargeService { get; set; }
    }
}
