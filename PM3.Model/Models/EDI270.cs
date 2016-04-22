using System;

namespace PM3.Model.Models
{
    public class EDI270
    {
        public int EDI270Id { get; set; }
        public int InsCoverageId { get; set; }
        public string PracticeProviderId { get; set; }
        public string ServiceTypeId { get; set; }
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
        public virtual Provider PracticeProvider { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual User User { get; set; }
    }
}
