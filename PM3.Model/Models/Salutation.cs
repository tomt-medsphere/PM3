using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class Salutation
    {
        public string SalutationId { get; set; }

        // children
        public virtual List<Person> Persons { get; set; }
    }
}
