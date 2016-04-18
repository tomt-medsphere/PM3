using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class TXMasterRARC
    {
        public int TXMasterRARCID { get; set; }
        public int TXMasterID { get; set; }
        public string RARID { get; set; }
        public int Sequence { get; set; }

        // parents
        public virtual TXMaster TXMaster { get; set; }
        public virtual RAR RAR { get; set; }
    }
}
