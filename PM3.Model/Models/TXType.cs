using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class TXType
    {
        public string TXTypeId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<TXCode> TXCodes { get; set; }
    }
}
