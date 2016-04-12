using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class EDIReport
    {
        public int EDIReportID { get; set; }
        public int EDIInboxID { get; set; }
        public string SenderID { get; set; }
        public string ReceiverID { get; set; }
        public DateTime ReceivedDateTime { get; set; }
        public bool Archived { get; set; }
        public string Description { get; set; }
        public string ReportID { get; set; }
        public string ReportText { get; set; }

        // parents
        public virtual EDIInbox EDIInbox { get; set; }
    }
}
