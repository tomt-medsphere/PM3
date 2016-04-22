namespace PM3.Model.Models
{
    public class TxCode
    {
        public string TxCodeId { get; set; }
        public string Description { get; set; }
        public string TxTypeId { get; set; }
        public string PaymentFormId { get; set; }
        public string PaymentCategoryId { get; set; }

        // parents
        public virtual TxType TxType { get; set; }
        public virtual PaymentForm PaymentForm { get; set; }
        public virtual PaymentCategory PaymentCategory { get; set; }
    }
}
