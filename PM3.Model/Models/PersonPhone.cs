using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class PersonPhone
    {
        public int PersonPhoneId { get; set; }
        public int PersonID { get; set; }
        public int PhoneID { get; set; }
        public int Sequence { get; set; }
        public string Note { get; set; }
    }
}
