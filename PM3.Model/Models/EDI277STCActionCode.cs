using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class EDI277STCActionCode
    {
        public string EDI277STCActionCodeID { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<EDI277STCAction> EDI277STCActions { get; set; }
    }
}
