using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class EmployerPhone
    {
        public int EmployerPhoneID { get; set; }
        public int EmployerID { get; set; }
        public int PhoneID { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual Employer Employer { get; set; }
        public virtual Phone Phone { get; set; }
    }
}
