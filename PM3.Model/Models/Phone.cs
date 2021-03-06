﻿using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class Phone
    {
        public int PhoneId { get; set; }
        public string PhoneTypeId { get; set; }
        public string ITUCountyId { get; set; }
        public string AreaCode { get; set; }
        public string LocalNumber { get; set; }
        public string Extension { get; set; }
        public string Note { get; set; }

        // parents
        public virtual PhoneType PhoneType { get; set; }
        public virtual ITUCountry ITUCountry { get; set; }

        // children
        public virtual List<EmployerPhone> EmployerPhones { get; set; }
        public virtual List<ExtFacilityPhone> ExtFacilityPhones { get; set; }
        public virtual List<ExtPracticeSitePhone> ExtPracticeSitePhones { get; set; }
        public virtual List<ExtProviderPhone> ExtProviderPhones { get; set; }
        public virtual List<InsPlanPhone> InsPlanPhones { get; set; }
        public virtual List<PersonPhone> PersonPhones { get; set; }
        public virtual List<PracticePhone> PracticePhones { get; set; }
        public virtual List<PracticeSitePhone> PracticeSitePhones { get; set; }
    }
}
