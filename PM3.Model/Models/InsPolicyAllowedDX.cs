using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class InsPolicyAllowedDX
    {
        public int InsPolicyAllowedDXId { get; set; }
        public int InsPolicyId { get; set; }
        public int ICDId { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual InsPolicy InsPolicy { get; set; }
        public virtual ICD ICD { get; set; }
    }
}
