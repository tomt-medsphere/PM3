using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class ExtPracticeSite
    {
        public int ExtPracticeSiteID { get; set; }
        public int ExtPracticeID { get; set; }
        public string Name { get; set; }
        public string AddressStreet { get; set; }
        public string AddressOther { get; set; }
        public string City { get; set; }
        public string USPSStateID { get; set; }
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
