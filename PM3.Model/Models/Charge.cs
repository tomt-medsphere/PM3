using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    class Charge
    {
        public int ChargeID { get; set; }
        public int PatientID { get; set; }
        public int BillingAccountID { get; set; }
        public string PracticeSiteID { get; set; }
        public int FacilityAdmissionID { get; set; }
        public string ExternalFacility { get; set; }
        public DateTime AdmitDateTime { get; set; }
        public DateTime DischargeDateTime { get; set; }
        public bool Emergency { get; set; }
        public string AccidentCodeID { get; set; }
        public string AccidentStateID { get; set; }

        public virtual List<ChargeInsCoverage> ChargeInsCoverages { get; set; } 

    }
}
