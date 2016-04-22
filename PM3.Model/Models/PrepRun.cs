using System;

namespace PM3.Model.Models
{
    public class PrepRun
    {
        public int PrepRunId { get; set; }
        public DateTime RunDateTime { get; set; }
        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
