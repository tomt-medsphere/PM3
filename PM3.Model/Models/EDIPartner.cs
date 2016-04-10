using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class EDIPartner
    {
        public string EDIPartnerID { get; set; }
        public string Name { get; set; }
        public string SubmitterID { get; set; }
        public string ReceiverID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string DUN { get; set; }
        public bool Testing { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string SiteID { get; set; }
        public string X12Version { get; set; }
        public string URL { get; set; }
        public string Note { get; set; }
        public bool Claims { get; set; }
        public bool ERA { get; set; }
        public bool Eligibility { get; set; }
        public bool Other { get; set; }
        public bool Inactive { get; set; }
    }
}
