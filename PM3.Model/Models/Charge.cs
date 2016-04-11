using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class Charge
    {
        public int ChargeID { get; set; }
        public int PatientID { get; set; }
        public int BillingAccountID { get; set; }
        public string PracticeSiteID { get; set; }
        public int FacilityAdmissionID { get; set; }
        public string ExternalFacilityID { get; set; }
        public DateTime AdmitDateTime { get; set; }
        public DateTime DischargeDateTime { get; set; }
        public bool Emergency { get; set; }
        public string PWKTransmissionCode { get; set; }
        public string PWKTypeCode { get; set; }
        public string PaperworkID { get; set; }
        // external provider
        public string RefProviderID { get; set; }
        public DateTime ReferralDate { get; set; }
        public string PCPID { get; set; }
        public DateTime PCPLastSeen { get; set; }
        public string NatureOfConditionID { get; set; }
        public DateTime LastXRay { get; set; }
        // work and accident
        public bool WorkRelated { get; set; }
        public DateTime DateOfInjury { get; set; }
        public DateTime InitialTreatmentDate { get; set; }
        public DateTime DateOfOnset { get; set; }
        public DateTime SameSimilarSysympton { get; set; }
        public DateTime AcuteManifestation { get; set; }
        public string DisabilityType { get; set; }
        public DateTime DisabilityStart { get; set; }
        public DateTime DisabilityEnd { get; set; }
        public DateTime LastWorked { get; set; }
        public DateTime ReturnToWork { get; set; }
        public string AccidentCodeID { get; set; }
        public string AccidentStateID { get; set; }
        public DateTime AccidentDateTime { get; set; }
        // misc
        public string CLIATypeID { get; set; }
        public string CLIANumber { get; set; }
        public string MammographyCert { get; set; }
        public string PriorAuthorizationCode { get; set; }
        public bool Pregnant { get; set; }
        public DateTime LMP { get; set; }
        public DateTime EDC { get; set; }
        public string EPSDTCode { get; set; }
        // system stuff
        public int EncounterBatchID { get; set; }
        public bool EncounterClosed { get; set; }
        public bool ForceToPaper { get; set; }
        public DateTime EntryDateTime { get; set; }
        public string UserID { get; set; }
        public bool EncounterPrepped { get; set; }
        public string CurrentPayerCoverageID { get; set; }

        // parents
        public virtual Patient Patient { set; get; }
        public virtual BillingAccount BillingAccount { get; set; }
        public virtual PracticeSite PracticeSite { get; set; }
        public virtual FacilityAdmission FacilityAddmission { get; set; }
        public virtual ExternalFacility ExternalFacility { get; set; }
        public virtual AccidentCode AccidentCode { get; set; }
        public virtual USPSState AccidentState { get; set; }

        //children
        public virtual List<ChargeInsCoverage> ChargeInsCoverages { get; set; } 


    }
}
