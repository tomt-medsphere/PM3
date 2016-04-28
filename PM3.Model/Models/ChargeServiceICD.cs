namespace PM3.Model.Models
{
    public class ChargeServiceICD
    {
        public int ChargeServiceICDId { get; set; }
        public int ChargeServiceId { get; set; }
        public int ICDId { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual ICD ICD { get; set; }
        public virtual ChargeService ChargeService { get; set; }
    }
}
