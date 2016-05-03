using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class PatientEHR
    {
        public int PatientId { get; set; }

        // parent
        public virtual Patient Patient { get; set; }
    }
}
