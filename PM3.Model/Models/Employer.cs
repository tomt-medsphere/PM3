using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class Employer
    {
        public int EmployerId { get; set; }
        public string Name { get; set; }
        public string AddressStreet { get; set; }
        public string AddressOther { get; set; }
        public string AddressCity { get; set; }
        public string USPSStateId { get; set; }
        public string PostalCode { get; set; }
        public string USPSCountryId { get; set; }
        public string Note { get; set; }
        public bool Inactive { get; set; }

        // parents
        public virtual USPSState USPSState { get; set; }
        public virtual USPSCountry USPSCountry { get; set; }

        // children
        public virtual List<Person> Persons { get; set; }
        public virtual List<EmployerPhone> EmployerPhones { get; set; }
    }
}
