namespace PM3.Model.Models
{
    public class ICD
    {
        public string ICDId { get; set; }
        public int Year { get; set; }
        public string System { get; set; }
        public string Version { get; set; }
        public bool FurtherSpecified { get; set; }
    }
}
