using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class ExtPracticeSitePhone
    {
        public int ExtPracticeSitePhoneID { get; set; }
        public int ExtPracticeSiteID { get; set; }
        public int PhoneID { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual ExtPractice ExtPractice { get; set; }
        public virtual Phone Phone { get; set; }
    }
}
