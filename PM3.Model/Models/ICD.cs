using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class ICD
    {
        public string ICDID { get; set; }
        public int Year { get; set; }
        public string System { get; set; }
        public string Version { get; set; }
        public bool FurtherSpecified { get; set; }
    }
}
