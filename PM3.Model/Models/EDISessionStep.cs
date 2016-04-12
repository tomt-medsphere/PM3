using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class EDISessionStep
    {
        public int EDISessionStepID { get; set; }
        public int EDISessionID { get; set; }
        public string EDISessionStageID { get; set; }
        public bool Error { get; set; }
        public int ClaimRunID { get; set; }
        public int StatementRunID { get; set; }
        public int EDIInboxID { get; set; }
        public string Message { get; set; }
        public string Filename { get; set; }

        // parents
        public virtual EDISession EDISession { get; set;}
        public virtual EDISessionStage EDISessionStage { get; set; }
        public virtual ClaimRun ClaimRun { get; set; }
        public virtual StatementRun StatementRun { get; set; }
        public virtual EDIInbox EDIInbox { get; set; }
    }
}
