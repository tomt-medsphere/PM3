using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class CMSSpeciality
    {
        public string CMSSpecialityId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<ExtProvider> ExtProviders { get; set; }
        public virtual List<TaxonomyCode> TaxomonyCodes { get; set; }
    }
}
