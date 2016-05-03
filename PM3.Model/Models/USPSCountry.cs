using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class USPSCountry
    {
        public string USPSCountryId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<Employer> Employers { get; set; }
        public virtual List<ExtFacility> ExtFacilities { get; set; }
        public virtual List<ExtPracticeSite> ExtPracticeSites { get; set; }
        public virtual List<InsPlan> InsPlans { get; set; }
        public virtual List<Person> Persons { get; set; }
    }
}
