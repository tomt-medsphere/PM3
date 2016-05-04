namespace PM3.Model.Models
{
    public class PracticeSitePhone
    {
        public int PracticeSitePhoneId { get; set; }
        public string PracticeSiteId { get; set; }
        public int PhoneId { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual PracticeSite PracticeSite { get; set; }
        public virtual Phone Phone { get; set; }
    }
}