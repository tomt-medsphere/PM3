namespace PM3.Model.Models
{
    public class StatementRunDetail
    {
        public int StatementRunDetailId { get; set; }
        public int StatementRunId { get; set; }
        public int BillingAccountId { get; set; }
        public string StatementData { get; set; }

        // parents
        public virtual StatementRun StatementRun { get; set; }
        public virtual BillingAccount BillingAccount { get; set; }
    }
}
