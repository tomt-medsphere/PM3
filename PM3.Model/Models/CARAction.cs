using PM3.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class CARAction
    {
        public string CARCodeID { get; set; }
        public string ShortDescription { get; set; }
        public bool SetReview { get; set; }
        public bool CreateTxNote { get; set; }
        public string TXCodeID { get; set; }

        // parents
        public virtual CAR CARCodes { get; set; }
        public virtual TXCode TXCodes { get; set; }
    }
}
