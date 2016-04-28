using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class ExtProvider
    {
        public string ExtProviderId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SuffixId { get; set; }
        public string Credentials { get; set; }
        public string Npi { get; set; }
        public string TaxonomyCodeId { get; set; }
        public string CmsSpecialityId { get; set; }
        public int ExternalPracticeId { get; set; }
        public int ExternalPracticeSiteId { get; set; }
        public bool Inactive { get; set; }

        // parents
        public virtual Suffix Suffix { get; set; }
        public virtual TaxonomyCode TaxonomyCode { get; set; }
        public virtual CMSSpeciality CMSSpeciality { get; set; }
        public virtual ExtPractice ExtPractice { get; set; }
        public virtual ExtPracticeSite ExtPracticeSite { get; set; }

        // children
        public virtual List<Patient> RefPatients { get; set; }
        public virtual List<Patient> PCPPatients { get; set; }
        public virtual List<ExtProviderPhone> ExtProviderPhones { get; set; }
        public virtual List<Charge> RefCharges { get; set; }
        public virtual List<Charge> PCPCharges { get; set; }
        public virtual List<ChargeService> OrderingChargeServices { get; set; }
    }
}
