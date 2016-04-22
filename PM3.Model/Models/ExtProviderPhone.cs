namespace PM3.Model.Models
{
    public class ExtProviderPhone
    {
        public int ExtProviderPhoneId { get; set; }
        public int ExtProviderId { get; set; }
        public int PhoneId { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual ExtProvider ExtProvider { get; set; }
        public virtual Phone Phone { get; set; }
    }
}
