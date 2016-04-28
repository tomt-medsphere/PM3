namespace PM3.Model.Models
{
    public class ChargeICD
    {
        public int ChargeICDId { get; set; }
        public int ChargeId { get; set; }
        public int ICDId { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual Charge Charge { get; set; }
        public virtual ICD ICD { get; set; }
    }
}
