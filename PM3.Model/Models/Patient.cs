using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace PM3.Model.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public int PersonId { get; set; }
        public string XRayId { get; set; }
        public string ChartNumber { get; set; }
        public string PracticeProviderId { get; set; }
        public bool InfoRelease { get; set; }
        public string InfoReleaseTypeId { get; set; }
        public DateTime InfoReleaseDate { get; set; }
        public bool PayProvider { get; set; }
        public string PayProviderTypeId { get; set; }
        public DateTime PayProviderDate { get; set; }
        public bool HIPAARelease { get; set; }
        public DateTime HIPAAReleaseDate { get; set; }
        public string PCPId { get; set; }
        public DateTime PCPLastSeen { get; set; }
        public DateTime LMP { get; set; }
        public DateTime EDC { get; set; }
        public bool Inactive { get; set; }

        // parents
        public virtual Person Person { get; set; }
        public virtual Provider PracticeProvider { get; set; }
        public virtual InfoReleaseType InfoReleaseType { get; set; }
        public virtual PayProviderType PayProviderType { get; set; }
        public virtual ExtProvider PCP { get; set; }

        // children
        public virtual List<Charge> Charges { get; set; }
        public virtual List<ChargeService> ChargeServices { get; set; }
        public virtual  List<FacilityAdmission> FacilityAdmissions { get; set; }
    }
}
