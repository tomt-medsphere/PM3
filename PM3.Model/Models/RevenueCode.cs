﻿using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class RevenueCode
    {
        public string RevenueCodeId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<Service> Services { get; set; }
    }
}
