using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class ExtFacilityPhone
    {
        public int ExtFacilityPhoneID { get; set; }
        public string ExtFacilityID { get; set; }
        public int PhoneID { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual ExtFacility ExtFacility { get; set; }
        public virtual Phone Phone { get; set; }
    }
}
