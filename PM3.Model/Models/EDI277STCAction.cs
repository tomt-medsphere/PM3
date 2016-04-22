using System;

namespace PM3.Model.Models
{
    public class EDI277STCAction
    {
        public int EDI277STCActionId { get; set; }
        public int EDI277STCId { get; set; }
        public string UserId { get; set; }
        public string EDI277ActionCodeId { get; set; }
        public DateTime ActionDateTime { get; set; }
        public string Note { get; set; }

        // parents
        public virtual EDI277STC EDI277STC { get; set; }
        public virtual User User { get; set; }
        public virtual EDI277STCActionCode EDI277ActionCode { get; set; }
    }
}
