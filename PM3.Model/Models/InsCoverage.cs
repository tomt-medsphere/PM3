using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class InsCoverage
    {
        public int InsCoverageId { get; set; }
        public int PatientId { get; set; }
        public int InsPolicyId { get; set; }
        public string RelationshipCodeId { get; set; }
        public string MemberId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Note { get; set; }
        public int Sequence { get; set; }
        public bool Inactive { get; set; }

        // parents
        public virtual Patient Patient { get; set; }
        public virtual InsPolicy InsPolicy { get; set; }
        public virtual RelationshipCode RelationshipCode { get; set; }

        // children
        public virtual List<EDI270> EDI270s { get; set; }
        public virtual List<ChargeInsCoverage> ChargeInsCoverages { get; set; }
    }
}
