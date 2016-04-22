namespace PM3.Model.Models
{
    public class ExtFacilityPhone
    {
        public int ExtFacilityPhoneId { get; set; }
        public string ExtFacilityId { get; set; }
        public int PhoneId { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual ExtFacility ExtFacility { get; set; }
        public virtual Phone Phone { get; set; }
    }
}
