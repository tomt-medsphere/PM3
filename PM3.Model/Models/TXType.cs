using PM3.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model
{
    public class TXType
    {
        public string TXTypeID { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<TXCode> TXCodes { get; set; }
    }
}
