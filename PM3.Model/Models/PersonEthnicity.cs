using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class PersonEthnicity
    {
        public int PersonEthnicityID { get; set; }
        public int PersonID { get; set; }
        public string CDCEthnicityID { get; set; }
        public int Sequence { get; set; }

        // parent
        public virtual Person Person { get; set; }
        public virtual CDCEthnicity CDCEthnicity { get; set; }
    }
}
