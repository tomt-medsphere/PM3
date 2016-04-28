using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class EDIInbox
    {
        public int EDIInboxId { get; set; }
        public DateTime ReceivedDateTime { get; set; }
        public string UserId { get; set; }
        public string FileText { get; set; }
        public string OriginalFileName { get; set; }
        public int EDISessionId { get; set; }

        // parents
        public virtual User User { get; set; }
        public virtual EDISession EDISession { get; set; }

        // children
        public virtual List<EDIReport> EDIReports { get; set; }
        public virtual List<EDISessionStep> EDISessionSteps { get; set; }
        public virtual List<EDI835> EDI835s { get; set; }
    }
}
