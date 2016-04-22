using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class TxType
    {
        public string TxTypeId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<TxCode> TxCodes { get; set; }
    }
}
