using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class PracticePhone
    {
        public int PracticePhoneId { get; set; }
        public string PracticeId { get; set; }
        public int PhoneId { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual Practice Practice { get; set; }
        public virtual Phone Phone { get; set; }
    }
}
