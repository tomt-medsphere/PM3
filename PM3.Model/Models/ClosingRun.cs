using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class ClosingRun
    {
        public int ClosingRunID { get; set; }
        public DateTime ClosingRunDateTime { get; set; }
        public string Description { get; set; }
        public string UserID { get; set; }

        // parents
        public virtual User User { get; set; }

        // children
        public virtual List<TXBatch> TXBatches { get; set; }
        public virtual List<ChargeBatch> ChargeBatches { get; set; }
    }
}
