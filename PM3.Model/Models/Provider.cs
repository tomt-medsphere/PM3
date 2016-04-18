using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class Provider
    {
        public string ProviderID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SuffixID { get; set; }
        public string Credentials { get; set; }
        public string SSN { get; set; }
        public string NPI { get; set; }
        public string TaxonomyCode { get; set; }
        public bool Supervised { get; set; }
        public bool NPP { get; set; }
        public string Note { get; set; }
        public bool Inactive { get; set; }
    }
}
