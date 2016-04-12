using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class ExternalProviderPhone
    {
        public int ExternalPracticePhoneID { get; set; }
        public int ExternalPracticeID { get; set; }
        public int PhoneID { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual ExternalPractice ExternalPractice { get; set; }
        public virtual Phone Phone { get; set; }
    }
}
