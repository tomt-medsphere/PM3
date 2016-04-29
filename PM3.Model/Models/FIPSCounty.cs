namespace PM3.Model.Models
{
    public class FipsCounty
    {
        public int FIPSCountyId { get; set; }
        public string USPSStateId { get; set; }
        public string StateFP { get; set; }
        public string CountyFP { get; set; }
        public string CountyName { get; set; }
        public string ClassFP { get; set; }

        // parents
        public virtual USPSState USPSState { get; set; }
    }
}
