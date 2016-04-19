using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class ExtProviderPhone
    {
        public int ExtPracticePhoneID { get; set; }
        public int ExtProviderID { get; set; }
        public int PhoneID { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual ExtProvider ExtProvider { get; set; }
        public virtual Phone Phone { get; set; }
    }
}
