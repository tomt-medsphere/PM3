﻿using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class EDICOBLevel
    {
        public string EDICOBLevelId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<InsPlan> InsPlans { get; set; }
    }
}
