using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class FacilityAdmission
    {
        public int FacilityAdmissionId { get; set; }
        public int PatientId { get; set; }
        public string ExtFacilityId { get; set; }
        public DateTime Admitted { get; set; }
        public DateTime Discharged { get; set; }
        public string Note { get; set; }
        public string MedicalRecordNumber { get; set; }

        // parents
        public virtual ExtFacility ExtFacility { get; set; }
        public virtual Patient Patient { get; set; }

        // children
        public virtual List<Charge> Charges { get; set; }
    }
}
