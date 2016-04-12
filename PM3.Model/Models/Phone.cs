using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class Phone
    {
        public int PhoneID { get; set; }
        public string PhoneTypeID { get; set; }
        public string ITUCountyID { get; set; }
        public string AreaCode { get; set; }
        public string LocalNumber { get; set; }
        public string Extension { get; set; }
        public string Note { get; set; }

        // parents
        public virtual PhoneType PhoneType { get; set; }
        public virtual ITUCountry ITUCountry { get; set; }
    }
}
