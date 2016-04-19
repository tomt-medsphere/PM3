using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class FIPSCounty
    {
        public int FIPSCountyID { get; set; }
        public string USPSStateID { get; set; }
        public string StateFP { get; set; }
        public string CountyFP { get; set; }
        public string CountyName { get; set; }
        public string ClassFP { get; set; }

        // parents
        public virtual USPSState USPSState { get; set; }
    }
}
