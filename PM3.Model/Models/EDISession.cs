using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class EDISession
    {
        public int EDISessionID { get; set; }
        public string EDIPartnerID { get; set; }
        public DateTime EDISessionDateTime { get; set; }
        public string EDISessionStatusID { get; set; }
        public string UserID { get; set; }

        // parents
        public virtual EDIPartner EDIPartner { get; set; }
        public virtual User User { get; set; }
        public virtual EDISessionStatus EDISessionStatus { get; set; }

        // children
        public virtual List<EDIInbox> EDIInbox { get; set; }
        public virtual List<EDISessionStep> EDISessionSteps { get; set; }
    }
}
