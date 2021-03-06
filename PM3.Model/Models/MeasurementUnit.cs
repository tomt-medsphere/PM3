﻿using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class MeasurementUnit
    {
        public string MeasurementUnitId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<ChargeService> ChargeServices { get; set; }

    }
}
