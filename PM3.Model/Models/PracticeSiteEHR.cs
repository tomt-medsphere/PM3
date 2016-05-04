using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class PracticeSiteEHR
    {
        public string PracticeSiteId { get; set; }

        // parents
        public virtual PracticeSite PracticeSite { get; set; }
    }
}
