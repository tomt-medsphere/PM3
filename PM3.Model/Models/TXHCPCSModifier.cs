namespace PM3.Model.Models
{
    public class TxHCPCSModifier
    {
        public int TxHCPCSModifierId { get; set; }
        public int TxId { get; set; }
        public string HCPCSModifierId { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual Tx Tx { get; set; }
        public virtual HCPCSModifier HCPCSModifier { get; set; }
    }
}
