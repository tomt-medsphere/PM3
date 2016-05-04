using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class PracticeSite
    {
        public string PracticeSiteId { get; set; }
        public string PracticeId { get; set; }
        public string Name { get; set; }
        public string CLIATypeId { get; set; }
        public string CLIANumber { get; set; }
        public DateTime CLIAExpires { get; set; }
        public string MammographyCertTypeId { get; set; }
        public DateTime MammographyCertExpires { get; set; }
        public string AddressStreet { get; set; }
        public string AddressOther { get; set; }
        public string City { get; set; }
        public string USPSStateId { get; set; }
        public string PostalCode { get; set; }
        public string USPSCountryId { get; set; }
        public bool Inactive { get; set; }

        // parents
        public virtual Practice Practice { get; set; }
        public virtual USPSState USPSState { get; set; }
        public virtual USPSCountry USPSCountry { get; set; }

        // children
        public virtual List<PracticeSitePhone> PracticeSitePhones { get; set; }
        public virtual List<Charge> Charges { get; set; }
        public virtual List<ChargeBatch> ChargeBatches { get; set; }
        public virtual List<TXBatch> TXBatches { get; set; }
        public virtual PracticeSiteEHR PracticeSiteEHR { get; set; }
    }
}
