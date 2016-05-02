using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class USPSCountry
    {
        public string USPSCountryId { get; set; }
        public string Description { get; set; }
        public List<Employer> Employers { get; set; }
        public List<ExtFacility> ExtFacilities { get; set; }
        public List<ExtPracticeSite> ExtPracticeSites { get; set; }
        public List<InsPlan> InsPlans { get; set; }
    }
}
