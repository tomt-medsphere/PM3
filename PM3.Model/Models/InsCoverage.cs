using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class InsCoverage
    {
        public int InsCoverageID { get; set; }
        public int PatientID { get; set; }
        public int InsPolicyID { get; set; }
        public string RelationshipCodeID { get; set; }
        public string MemberID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Note { get; set; }
        public int Sequence { get; set; }
        public bool Inactive { get; set; }

        // parents
        public virtual Patient Patient { get; set; }
        public virtual InsPolicy InsPolicy { get; set; }
        public virtual RelationshipCode RelationshipCode { get; set; }
    }
}
