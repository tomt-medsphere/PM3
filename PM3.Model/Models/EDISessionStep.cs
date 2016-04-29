namespace PM3.Model.Models
{
    public class EDISessionStep
    {
        public int EDISessionStepId { get; set; }
        public int EDISessionId { get; set; }
        public string EDISessionStageId { get; set; }
        public bool Error { get; set; }
        public int? ClaimRunId { get; set; }
        public int? StatementRunId { get; set; }
        public int? EDIInboxId { get; set; }
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
