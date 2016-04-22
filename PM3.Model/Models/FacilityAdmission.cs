using System;

namespace PM3.Model.Models
{
    public class FacilityAdmission
    {
        public int FacilityAdmissionId { get; set; }
        public int PatientId { get; set; }
        public string ExternalFacilityId { get; set; }
        public DateTime Admitted { get; set; }
        public DateTime Discharged { get; set; }
        public string Note { get; set; }
        public string MEDIcalRecordNumber { get; set; }

        // parents
        public virtual ExtFacility ExtFacility { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
