using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class EDI270
    {
        public int EDI270Id { get; set; }
        public int InsCoverageId { get; set; }
        public string ProviderId { get; set; }
        public string TOSId { get; set; }
        public DateTime RequestDateOfService { get; set; }
        public bool CoverageActive { get; set; }
        public DateTime InquiryDateTime { get; set; }
        public string EDI270Txt { get; set; }
        public string InquiryStatus { get; set; }
        public string EDI271Txt { get; set; }
        public DateTime? CoverageStartDate { get; set; }
        public DateTime? CoverageEndDate { get; set; }
        public string UserId { get; set; }

        // parents
        public virtual InsCoverage InsCoverage { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual TOS TOS { get; set; }
        public virtual User User { get; set; }

        // children
        public virtual List<EDI270> EDI270s { get; set; }
    }
}
