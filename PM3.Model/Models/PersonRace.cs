using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class PersonRace
    {
        public int PersonRaceID { get; set; }
        public int PersonID { get; set; }
        public string CDCRaceID { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual Person Person { get; set;}
        public virtual CDCRace CDCRace { get; set; }
    }
}
