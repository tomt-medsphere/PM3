using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class PracticeSite
    {
        public string PracticeSiteID { get; set; }
        public string Name { get; set; }
        public string CLIATypeID { get; set; }
        public string CLIANumber { get; set; }
        public DateTime CLIAExpires { get; set; }
        public string MammographyCertTypeID { get; set; }
        public DateTime MammographyCertExpires { get; set; }
        public string AddressStreet { get; set; }
        public string AddressOther { get; set; }
        public string AddressCity { get; set; }
        public string AddressUSPSStateID { get; set; }
        public string AddressPostalCode { get; set; }
        public string AddressUSPSCountryID { get; set; }
        public bool Inactive { get; set; }
    }
}
