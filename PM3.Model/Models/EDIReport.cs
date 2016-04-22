using System;

namespace PM3.Model.Models
{
    public class EDIReport
    {
        public int EDIReportId { get; set; }
        public int EDIInboxId { get; set; }
        public string SenderId { get; set; }
        public string ReceiverId { get; set; }
        public DateTime ReceivedDateTime { get; set; }
        public bool Archived { get; set; }
        public string Description { get; set; }
        public string ReportId { get; set; }
        public string ReportText { get; set; }

        // parents
        public virtual EDIInbox EDIInbox { get; set; }
    }
}
