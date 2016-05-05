using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class ServiceMacroDetail
    {
        public string ServiceMacroId { get; set; }
        public string ServiceId { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual ServiceMacro ServiceMacro { get; set; }
        public virtual Service Service { get; set; }
    }
}
