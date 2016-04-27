namespace PM3.Model.Models
{
    public class TXHCPCSModifier
    {
        public int TXHCPCSModifierId { get; set; }
        public int TXId { get; set; }
        public string HCPCSModifierId { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual TX TX { get; set; }
        public virtual HCPCSModifier HCPCSModifier { get; set; }
    }
}
