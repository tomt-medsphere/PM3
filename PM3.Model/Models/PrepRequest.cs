using System;

namespace PM3.Model.Models
{
    public class PrepRequest
    {
        public int PrepRequestId { get; set; }
        public int ChargeId { get; set; }
        public int ChargeInsCoverageId { get; set; }
        public string UserId { get; set; }
        public DateTime RequestDateTime { get; set; }

        // parents
        public virtual ChargeInsCoverage ChargeInsCoverage { get; set; }
        public virtual Charge Charge { get; set; }
        public virtual User User { get; set; }
    }
}
