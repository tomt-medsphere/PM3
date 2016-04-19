using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class Employer
    {
        public int EmployerID { get; set; }
        public string Name { get; set; }
        public string AddressStreet { get; set; }
        public string AddressOther { get; set; }
        public string AddressCity { get; set; }
        public string USPSStateID { get; set; }
        public string PostalCode { get; set; }
        public string USPSCountryID { get; set; }
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
