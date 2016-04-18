using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class ChargeBatch
    {
        public int ChargeBatchID { get; set; }
        public string PostingPeriodID { get; set; }
        public string PracticeSiteID { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ClosedDateTime { get; set; }
        public bool ReadyToClose { get; set; }
        public int? ClosingRunID { get; set; }
        public string UserID { get; set; }

        // parents
        public virtual PostingPeriod PostingPeriod { get; set; }
        public virtual PracticeSite PracticeSite { get; set; }
        public virtual ClosingRun ClosingRun { get; set; }
        public virtual  User User { get; set; }

        // children
        public virtual List<Charge> Charges { get; set; }
    }
}
