using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class TOS
    {
        public string TOSId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<EDI270> EDI270s { get; set; }
    }
}
