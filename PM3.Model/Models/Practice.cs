using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class Practice
    {
        public string PracticeId { get; set; }
        public string Name { get; set; }
        public string EntityTypeId { get; set; }
        public string EIN { get; set; }
        public string Note { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SuffixId { get; set; }
        public string NPI { get; set; }
        public string TaxonomyCodeId { get; set; }
        public string AddressStreet { get; set; }
        public string AddressOther { get; set; }
        public string City { get; set; }
        public string USPSStateId { get; set; }
        public string PostalCode { get; set; }
        public string USPSCountryId { get; set; }
        public string RemitStreet { get; set; }
        public string RemitOther { get; set; }
        public string RemitCity { get; set; }
        public string RemitUSPSStateId { get; set; }
        public string RemitPostalCode { get; set; }
        public string RemitUSPSCountryId { get; set; }
        public int MaxPasswordAge { get; set; }
        public int MinPasswordLength { get; set; }
        public int MaxPasswordFailure { get; set; }
        public int ScreenTimeout { get; set; }
        public int LoginFailureWithinMin { get; set; }

        // parents
        public virtual USPSState USPSState { get; set; }
        public virtual USPSState RemitUSPSState { get; set; }
        public virtual USPSCountry USPSCountry { get; set; }
        public virtual USPSCountry RemitUSPSCountry { get; set; }
        public virtual TaxonomyCode TaxonomyCode { get; set; }

        // children
        public virtual List<PracticePhone> PracticePhones { get; set; }
        public virtual List<PracticeSite> PracticeSites { get; set; }
        public virtual PracticeEHR PracticeEHR { get; set; }
    }
}
