using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class Suffix
    {
        public string SuffixId { get; set; }

        // children
        public virtual  List<ExtProvider> ExtProviders { get; set; }
        public virtual List<Person> Persons { get; set; }
    }
}
