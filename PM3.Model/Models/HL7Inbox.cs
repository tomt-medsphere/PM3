using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class HL7Inbox
    {
        public int HL7InboxId { get; set; }
        public DateTime Received { get; set; }
        public DateTime Processed { get; set; }
        public string MessageType { get; set; }
        public string EventId { get; set; }
        public string Message { get; set; }
        public int HL7OutBoxId { get; set; }

        // parents
        public virtual HL7Outbox AcknowledgesHL7Outbox { get; set; }
    }
}
