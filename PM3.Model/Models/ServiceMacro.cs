using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class ServiceMacro
    {
        public string ServiceMacroId { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }

        // children
        public virtual List<ServiceMacroDetail> ServiceMacroDetails { get; set; }
    }
}
