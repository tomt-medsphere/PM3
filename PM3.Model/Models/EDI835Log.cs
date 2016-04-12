using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class EDI835Log
    {
        public int EDI835LogID { get; set; }
        public int EDI835ID { get; set; }
        public DateTime MessageDateTime { get; set; }
        public string Message { get; set; }

        // parent
        public virtual EDI835 EDI835 { get; set; }
    }
}
