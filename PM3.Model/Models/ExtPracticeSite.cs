using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class ExtPracticeSite
    {
        public int ExtPracticeSiteId { get; set; }
        public int ExtPracticeId { get; set; }
        public string Name { get; set; }
        public string AddressStreet { get; set; }
        public string AddressOther { get; set; }
        public string City { get; set; }
        public string USPSStateId { get; set; }
        public string PostalCode { get; set; }
        public bool Inactive { get; set; }

        // parents
        public virtual ExtPractice ExtPractice { get; set; }
        public virtual USPSState USPSState { get; set; }

        // children
        public virtual List<ExtPracticeSitePhone> ExtPracticeSitePhones { get; set; }
        public virtual List<ExtProvider> ExtProviders { get; set; }
    }
}
