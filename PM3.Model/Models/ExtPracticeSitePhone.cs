namespace PM3.Model.Models
{
    public class ExtPracticeSitePhone
    {
        public int ExtPracticeSitePhoneId { get; set; }
        public int ExtPracticeSiteId { get; set; }
        public int PhoneId { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual  ExtPracticeSite ExtPracticeSite { get; set; }
        public virtual Phone Phone { get; set; }
    }
}
