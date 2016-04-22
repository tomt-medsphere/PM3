using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class EDISessionStage
    {
        public string EDISessionStageId { get; set; }
        public string Description { get; set; }

        // child
        public virtual List<EDISessionStep> EDISessionSteps { get; set; }
    }
}
