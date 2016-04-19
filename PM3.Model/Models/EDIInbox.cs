using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class EDIInbox
    {
        public int EDIInboxID { get; set; }
        public DateTime ReceivedDateTime { get; set; }
        public string UserID { get; set; }
        public string FileText { get; set; }
        public string OriginalFileName { get; set; }
        public int EDISessionID { get; set; }

        // parents
        public virtual User User { get; set; }
        public virtual EDISession EDISession { get; set; }

        // children
        public virtual List<EDIReport> EDIReports { get; set; }
        public virtual List<EDISessionStep> EDISessionSteps { get; set; }
    }
}
