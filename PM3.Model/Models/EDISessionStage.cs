using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class EDISessionStage
    {
        public string EDISessionStageID { get; set; }
        public string Description { get; set; }

        // child
        public virtual List<EDISessionStep> EDISessionSteps { get; set; }
    }
}
