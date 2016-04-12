using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class ExternalSystemMap
    {
        public int ExternalSystemMapID { get; set; }
        public string ExternalSystemID { get; set; }
        public string ExternalEntityID { get; set; }
        public string EntityTypeID { get; set; }
        public string EntityID { get; set; }

        // parents
        public virtual ExternalSystem ExternalSystem { get; set; }
        public virtual EntityType EntityType { get; set; }
    }
}
