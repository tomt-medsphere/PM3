using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class PlanProfileEvent
    {
        public int PlanProfileEventId { get; set; }
        public int PlanProfileDetailId { get; set; }
        public int TXId { get; set; }
        public DateTime EventDateTime { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
        public string UserId { get; set; }
        public string EventReasonCode { get; set; }
        public string EventAction { get; set; }
        public string HCPCSId { get; set; }
        public string HCPCSModifierId { get; set; }
        
       

        // parents
        public virtual PlanProfileDetail PlanProfileDetail { get; set; }
        public virtual HCPCS HCPCS { get; set; }
        public virtual HCPCSModifier HCPCSModifier { get; set; }
    }
}
