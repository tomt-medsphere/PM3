﻿using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class Provider
    {
        public string ProviderId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SuffixId { get; set; }
        public string Credentials { get; set; }
        public string Ssn { get; set; }
        public string Npi { get; set; }
        public string TaxonomyCode { get; set; }
        public bool Supervised { get; set; }
        public bool Npp { get; set; }
        public string Note { get; set; }
        public bool Inactive { get; set; }

        // children
        public virtual List<ChargeService> RenderingChargeServices { get; set; }
        public virtual List<ChargeService> SupervisingChargeServices { get; set; }
        public virtual List<EDI270> EDI270s { get; set; }

    }
}
