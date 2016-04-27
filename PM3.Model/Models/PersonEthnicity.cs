namespace PM3.Model.Models
{
    public class PersonEthnicity
    {
        public int PersonEthnicityId { get; set; }
        public int PersonId { get; set; }
        public string CDCEthnicityId { get; set; }
        public int Sequence { get; set; }

        // parent
        public virtual Person Person { get; set; }
        public virtual CDCEthnicity CDCEthnicity { get; set; }
    }
}
