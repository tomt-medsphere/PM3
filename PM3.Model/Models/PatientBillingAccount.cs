namespace PM3.Model.Models
{
    public class PatientBillingAccount
    {
        public int PatientBillingAccountId { get; set; }
        public int PatientId { get; set; }
        public int BillingAccountId { get; set; }
        public string RelationshipCodeId { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual Patient Patient { get; set; }
        public virtual BillingAccount BillingAccount { get; set; }
        public virtual RelationshipCode RelationshipCode { get; set; }
    }
}
