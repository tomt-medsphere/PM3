using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class EDI277
    {
        public int EDI277ID { get; set; }
        public int ClaimRunID { get; set; }
        public string EDI277txt { get; set; }
        public string SourceID { get; set; }
        public string SourceName { get; set; }
        public DateTime SourceProcessDate { get; set; }

        // parents
        public virtual ClaimRun ClaimRun { get; set; }
    }
}
