using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class InsPlanPhone
    {
        public int InsPlanPhoneId { get; set; }
        public string InsPlanId { get; set; }
        public int PhoneId { get; set; }
        public string Department { get; set; }
        public int Sequence { get; set; }
        
        // parents
        public virtual InsPlan InsPlan { get; set; }
        public virtual Phone Phone { get; set; }
    }
}
