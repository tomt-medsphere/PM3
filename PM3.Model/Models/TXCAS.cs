namespace PM3.Model.Models
{
    public class TXCAS
    {
        public int TXCASId { get; set; }
        public int TXId { get; set; }
        public string CAGCodeId { get; set; }
        public string CARCodeId { get; set; }
        public decimal Amount { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual TX TX { get; set; }
        public virtual CAGCode CAGCode { get; set; }
        public virtual CARCode CARCode { get; set; }
    }
}
