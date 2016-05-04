using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class PracticeEHR
    {
        public string PracticeId { get; set; }

        // parent
        public virtual Practice Practice { get; set; }
    }
}
