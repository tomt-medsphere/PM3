using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class TaxonomyCode
    {
        public string TaxonomyCodeId { get; set; }
        public string Classification { get; set; }
        public string CMSSpecialityId { get; set; }

        // parents
        public virtual CMSSpeciality CMSSpeciality { get; set; }
        public List<ExtProvider> ExtProviders { get; set; }
    }
}
