using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class ExternalProvider
    {
        public string ExternalProviderID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SuffixID { get; set; }
        public string Credentials { get; set; }
        public string NPI { get; set; }
        public string TaxonomyCodeID { get; set; }
        public string CMSSpecialityID { get; set; }
        public int ExternalPracticeID { get; set; }
        public int ExternalPracticeSiteID { get; set; }
        public bool Inactive { get; set; }

    }
}
