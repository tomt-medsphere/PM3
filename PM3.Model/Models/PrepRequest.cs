using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class PrepRequest
    {
        public int PrepRequestID { get; set; }
        public int ChargeID { get; set; }
        public int ChargeInsCoverageID { get; set; }
        public string UserID { get; set; }
        public DateTime RequestDateTime { get; set; }

        // parents
        public virtual ChargeInsCoverage ChargeInsCoverage { get; set; }
        public virtual Charge Charge { get; set; }
        public virtual User User { get; set; }
    }
}
