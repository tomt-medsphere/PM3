namespace PM3.Model.Models
{
    public class EmployerPhone
    {
        public int EmployerPhoneId { get; set; }
        public int EmployerId { get; set; }
        public int PhoneId { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual Employer Employer { get; set; }
        public virtual Phone Phone { get; set; }
    }
}
