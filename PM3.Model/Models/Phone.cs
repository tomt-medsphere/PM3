namespace PM3.Model.Models
{
    public class Phone
    {
        public int PhoneId { get; set; }
        public string PhoneTypeId { get; set; }
        public string ItuCountyId { get; set; }
        public string AreaCode { get; set; }
        public string LocalNumber { get; set; }
        public string Extension { get; set; }
        public string Note { get; set; }

        // parents
        public virtual PhoneType PhoneType { get; set; }
        public virtual ITUCountry ITUCountry { get; set; }
    }
}
