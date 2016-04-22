namespace PM3.Model.Models
{
    public class FipsCounty
    {
        public int FipsCountyId { get; set; }
        public string USPSStateId { get; set; }
        public string StateFp { get; set; }
        public string CountyFp { get; set; }
        public string CountyName { get; set; }
        public string ClassFp { get; set; }

        // parents
        public virtual USPSState USPSState { get; set; }
    }
}
