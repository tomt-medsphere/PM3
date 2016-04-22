using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class EDISession
    {
        public int EDISessionId { get; set; }
        public string EDIPartnerId { get; set; }
        public DateTime EDISessionDateTime { get; set; }
        public string EDISessionStatusId { get; set; }
        public string UserId { get; set; }

        // parents
        public virtual EDIPartner EDIPartner { get; set; }
        public virtual User User { get; set; }
        public virtual EDISessionStatus EDISessionStatus { get; set; }

        // children
        public virtual List<EDIInbox> EDIInbox { get; set; }
        public virtual List<EDISessionStep> EDISessionSteps { get; set; }
    }
}
