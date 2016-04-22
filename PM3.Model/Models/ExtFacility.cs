using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class ExtFacility
    {
        public string ExtFacilityId { get; set; }
        public string Name { get; set; }
        public String AddressStreet { get; set; }
        public string AddressOther { get; set; }
        public string City { get; set; }
        public string USPSStateId { get; set; }
        public string PostalCode { get; set; }
        public string USPSCountryId { get; set; }
        public string Npi { get; set; }
        public bool Inactive { get; set; }

        // parents
        public virtual USPSState USPSState { get; set; }
        public virtual USPSCountry USPSCountry { get; set; }

        // children
        public virtual List<Charge> Charges { get; set; }
        public virtual List<FacilityAdmission> FacilityAddmissions { get; set; }
        public virtual List<ExtFacility> ExtFacilities { get; set; }
    }
}
