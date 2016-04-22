using System;

namespace PM3.Model.Models
{
    public class PostingPeriod
    {
        public string PostingPeriodId { get; set; }
        public string CreatedUserId { get; set; }
        public string ClosedUserId { get; set; }
        public DateTime ClosedDateTime { get; set; }
    }
}
