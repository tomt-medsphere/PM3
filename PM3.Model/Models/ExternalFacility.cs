using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class ExternalFacility
    {
        public string ExternalFacilityID { get; set; }
        public string Name { get; set; }
        public String AddressStreet { get; set; }
        public string AddressOther { get; set; }
        public string AddressCity { get; set; }
        public string AddressUSPSStateID { get; set; }
        public string AddressPostalCode { get; set; }
        public string AddressUSPSCountryID { get; set; }
        public string NPI { get; set; }
        public bool Inactive { get; set; }
    }
}
