using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class ExtPractice
    {
        public int ExtPracticeId { get; set; }
        public string Name { get; set; }
        public bool Inactive { get; set; }

        // children
        public virtual List<ExtPracticeSite> ExtPracticeSites { get; set; }
        public virtual List<ExtProvider> ExtProviders { get; set; }
    }
}
