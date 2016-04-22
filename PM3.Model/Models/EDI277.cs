using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class EDI277
    {
        public int EDI277Id { get; set; }
        public int ClaimRunId { get; set; }
        public string EDI277Txt { get; set; }
        public string SourceId { get; set; }
        public string SourceName { get; set; }
        public DateTime? SourceProcessDate { get; set; }

        // parents
        public virtual ClaimRun ClaimRun { get; set; }

        // children
        public virtual List<EDI277STC> EDI277STC { get; set; }
    }
}
