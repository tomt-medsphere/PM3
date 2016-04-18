using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class EDI277STCAction
    {
        public int EDI277STCActionID { get; set; }
        public int EDI277STCID { get; set; }
        public string UserID { get; set; }
        public string EDI277ActionCodeID { get; set; }
        public DateTime ActionDateTime { get; set; }
        public string Note { get; set; }

        // parents
        public virtual EDI277STC EDI277STC { get; set; }
        public virtual User User { get; set; }
        public virtual EDI277STCActionCode EDI277ActionCode { get; set; }
    }
}
