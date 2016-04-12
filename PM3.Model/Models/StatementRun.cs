using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class StatementRun
    {
        public int StatementRunID { get; set; }
        public DateTime StatementRunDateTime { get; set; }
        public bool EDI { get; set; }
        public string StatementRunStatusID { get; set; }
        public string UserID { get; set; }

        // parents
        public virtual StatementRunStatus StatementRunStatus { get; set; }
        public virtual User User { get; set; }
    }
}
