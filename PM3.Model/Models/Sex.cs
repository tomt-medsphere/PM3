using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class Sex
    {
        public string SexId { get; set; }

        // children
        public virtual List<Person> Persons { get; set; }
    }
}
