using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class RARC
    {
        public string RARCId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<TXMasterRARC> TXMasterRARCs { get; set; }
    }
}
