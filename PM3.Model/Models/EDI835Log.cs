using System;

namespace PM3.Model.Models
{
    public class EDI835Log
    {
        public int EDI835LogId { get; set; }
        public int EDI835Id { get; set; }
        public DateTime MessageDateTime { get; set; }
        public string Message { get; set; }

        // parent
        public virtual EDI835 EDI835 { get; set; }
    }
}
