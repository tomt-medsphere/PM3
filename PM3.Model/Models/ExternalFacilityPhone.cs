using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class ExternalFacilityPhone
    {
        public int ExternalFacilityPhoneID { get; set; }
        public string ExternalFacilityID { get; set; }
        public int PhoneID { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual ExternalFacility ExternalFacility { get; set; }
        public virtual Phone Phone { get; set; }
    }
}
