namespace PM3.Model.Models
{
    public class TxCAS
    {
        public int TxCASId { get; set; }
        public int TxId { get; set; }
        public string CagCodeId { get; set; }
        public string CarCodeId { get; set; }
        public decimal Amount { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual Tx Tx { get; set; }
        public virtual CagCode CagCode { get; set; }
        public virtual Car CarCode { get; set; }
    }
}
