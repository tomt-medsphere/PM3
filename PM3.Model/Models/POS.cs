﻿using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class POS
    {
        public string POSId { get; set; }
        public string Description { get; set; }
        public string CMSPOSId { get; set; }

        // children
        public virtual List<ChargeService> ChargeServices { get; set; }
        public virtual List<Service> Services { get; set; }

    }
}
