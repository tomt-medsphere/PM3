using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class PrepRun
    {
        public int PrepRunID { get; set; }
        public DateTime RunDateTime { get; set; }
        public string UserID { get; set; }

        public virtual User User { get; set; }
    }
}
