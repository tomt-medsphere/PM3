using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class PracticeSite
    {
        public string PracticeSiteId { get; set; }
        public string Name { get; set; }
        public string CliaTypeId { get; set; }
        public string CliaNumber { get; set; }
        public DateTime CliaExpires { get; set; }
        public string MammographyCertTypeId { get; set; }
        public DateTime MammographyCertExpires { get; set; }
        public string AddressStreet { get; set; }
        public string AddressOther { get; set; }
        public string AddressCity { get; set; }
        public string AddressUSPSStateId { get; set; }
        public string AddressPostalCode { get; set; }
        public string AddressUSPSCountryId { get; set; }
        public bool Inactive { get; set; }

        // parents

        // children
        public virtual List<Charge> Charges { get; set; }
    }
}
