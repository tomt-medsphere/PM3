using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class ExternalPracticeSite
    {
        public int ExternalPracticeSiteID { get; set; }
        public int ExternalPracticeID { get; set; }
        public string Name { get; set; }
        public string AddressStreet { get; set; }
        public string AddressOther { get; set; }
        public string AddressCity { get; set; }
        public string USPSStateID { get; set; }
        public string PostalCode { get; set; }
        public bool Inactive { get; set; }

        // parents
        public virtual ExternalPractice ExternalPractice { get; set; }
        public virtual USPSState USPSState { get; set; }
    }
}
