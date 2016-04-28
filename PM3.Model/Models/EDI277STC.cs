using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class EDI277STC
    {
        public int EDI277STCId { get; set; }
        public int EDI277Id { get; set; }
        public int ClaimId { get; set; }
        public int ChargeId { get; set; }
        public int ChargeServiceId { get; set; }
        public string STCSegment { get; set; }
        public string Ref1K { get; set; }

        // parent
        public virtual EDI277 EDI277 { get; set; }
        public virtual Claim Claim { get; set; }
        public virtual Charge Charge { get; set; }
        public virtual ChargeService ChargeService { get; set; }

        // children
        public virtual List<EDI277STCAction> EDI277STCActions { get; set; }
        public virtual List<Charge> Charges { get; set; }

    }
}
