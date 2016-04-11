using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class PostingPeriod
    {
        public string PostingPeriodID { get; set; }
        public string CreatedUserID { get; set; }
        public string ClosedUserID { get; set; }
        public DateTime ClosedDateTime { get; set; }
    }
}
