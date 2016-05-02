using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class RelationshipCode
    {
        public string RelationshipCodeId { get; set; }
        public string Description { get; set; }
        public List<InsCoverage> InsCoverages { get; set; }
    }
}
