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

        public virtual User User { get; set; }
    }
}
