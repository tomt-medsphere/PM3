using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class EDISessionStatus
    {
        public string EDISessionStatusId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<EDISession> EDISessions { get; set; }
    }
}
