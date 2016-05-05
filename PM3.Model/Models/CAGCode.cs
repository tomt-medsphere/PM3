using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class CAGCode
    {
        public string CAGCodeId { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        // children
        public virtual List<TX> TXs { get; set; }
        public virtual List<TXCAS> TXCASs { get; set; }
    }
}
