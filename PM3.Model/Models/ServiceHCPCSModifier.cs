namespace PM3.Model.Models
{
    public class ServiceHCPCSModifier
    {
        public int ServiceHCPCSModifierId { get; set; }
        public string ServiceId { get; set; }
        public string HCPCSModifierId { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual Service Service { get; set; }
        public virtual HCPCSModifier HCPCSModifier { get; set; }
    }
}
