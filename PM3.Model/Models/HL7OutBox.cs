using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class HL7Outbox
    {
        public int HL7OutboxId { get; set; }
        public DateTime Created { get; set; }
        public DateTime  Sent { get; set; }
        public string ReceivingApplication { get; set; }
        public string MessageType { get; set; }
        public string EventId { get; set; }
        public string Message { get; set; }
        public string Result { get; set; }

        // children
        public virtual HL7Inbox AcknowledgedBy { get; set; }
    }
}
