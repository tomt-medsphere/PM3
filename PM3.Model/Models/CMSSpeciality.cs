using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class CMSSpeciality
    {
        public string CMSSpecialityID { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<ExtProvider> ExtProviders { get; set; }
        public virtual List<TaxonomyCode> TaxomonyCodes { get; set; }
    }
}
