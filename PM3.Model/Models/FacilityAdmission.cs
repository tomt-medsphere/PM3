using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class FacilityAdmission
    {
        public int FacilityAdmissionID { get; set; }
        public int PatientID { get; set; }
        public string ExternalFacilityID { get; set; }
        public DateTime Admitted { get; set; }
        public DateTime Discharged { get; set; }
        public string Note { get; set; }
        public string MedicalRecordNumber { get; set; }
    }
}
