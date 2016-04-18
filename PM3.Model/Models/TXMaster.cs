using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class TXMaster
    {
        public int TXMasterID { get; set; }
        public int TXBatchID { get; set; }
        public DateTime EntryDateTime { get; set; }
        public decimal Amount { get; set; }
        public string Note { get; set; }
        public string InsPlanID { get; set; }
        public string ICN { get; set; }

        // parents
        public virtual TXBatch TXBatch { get; set; }
        
        // children
        public virtual List<TX> TX { get; set; }
        public virtual List<TXMasterRARC> TXMasterRARC { get; set; }
    }
}
