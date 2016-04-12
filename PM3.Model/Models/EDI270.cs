using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class EDI270
    {
        public int EDI270ID { get; set; }
        public int InsCoverageID { get; set; }
        public string PracticeProviderID { get; set; }
        public string ServiceTypeID { get; set; }
        public DateTime RequestDateOfService { get; set; }
        public bool CoverageActive { get; set; }
        public DateTime InquiryDateTime { get; set; }
        public string EDI270txt { get; set; }
        public string InquiryStatus { get; set; }
        public string EDI271txt { get; set; }
        public DateTime CoverageStartDate { get; set; }
        public DateTime CoverageEndDate { get; set; }
        public string UserID { get; set; }

        // parents
        public virtual InsCoverage InsCoverage { get; set; }
        public virtual PracticeProvider PracticeProvider { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual User User { get; set; }
    }
}
