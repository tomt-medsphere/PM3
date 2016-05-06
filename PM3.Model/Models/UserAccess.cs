using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class UserAccess
    {
        public int UserAccessId { get; set; }
        public string UserId { get; set; }
        public DateTime AccessDateTime { get; set; }
        public string Action { get; set; }
        public string IPAddress { get; set; }
        public string Note { get; set; }

        // parents
        public virtual User User { get; set; }
    }
}
