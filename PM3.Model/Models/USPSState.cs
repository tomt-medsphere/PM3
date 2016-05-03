using System.Collections.Generic;
using System.ComponentModel.Design;

namespace PM3.Model.Models
{
    public class USPSState
    {
        public string USPSStateId { get; set; }
        public string Name { get; set; }

        // children
        public virtual List<Charge> Charges { get; set; }
        public virtual List<Employer> Employers { get; set; }
        public virtual List<ExtFacility> ExtFacilities { get; set; }
        public virtual List<ExtPracticeSite> ExtPracticeSites { get; set; }
        public virtual List<FipsCounty> FIPSCounties { get; set; }
        public virtual List<InsPlan> InsPlans { get; set; }
        public virtual List<Person> Persons { get; set; }
    }
}
