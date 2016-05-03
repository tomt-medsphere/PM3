using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class RelationshipCode
    {
        public string RelationshipCodeId { get; set; }
        public string Description { get; set; }

        // children
        public List<InsCoverage> InsCoverages { get; set; }
        public virtual List<PatientBillingAccount> PatientBillingAccounts { get; set; }
        public virtual List<Person> GuardianPersons { get; set; }
        public virtual List<Person> EmergencyContactPersons { get; set; }
    }
}
