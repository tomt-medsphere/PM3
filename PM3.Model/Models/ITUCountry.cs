using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class ITUCountry
    {
        public string ITUCountryId { get; set; }
        public string Name { get; set; }

        // children
        public virtual List<Phone> Phones { get; set; }
    }
}
