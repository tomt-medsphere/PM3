using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class Suffix
    {
        public string SuffixId { get; set; }

        // children
        public virtual  List<ExtProvider> ExtProviders { get; set; }
        public virtual List<Person> Persons { get; set; }
        public virtual List<Provider> Providers { get; set; }
        public virtual List<User> Users { get; set; }
    }
}
