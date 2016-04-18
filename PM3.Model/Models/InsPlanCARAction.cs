using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class InsPlanCARAction
    {
        public string CARID { get; set; }
        public string InsPlanID { get; set; }
        public string ShortDescription { get; set; }
        public bool SetReviewStatus { get; set; }
        public bool CreateTXNote { get; set; }
        public string TXCodeID { get; set; }

        // parents
        public virtual CAR CAR { get; set; }
        public virtual InsPlan InsPlan { get; set; }
    }
}
