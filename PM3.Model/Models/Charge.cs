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
        public int? FacilityAdmissionID { get; set; }
        public string ExtFacilityID { get; set; }
        public DateTime? AdmitDateTime { get; set; }
        public DateTime? DischargeDateTime { get; set; }
        public string PWKTransmissionCodeID { get; set; }
        public string PWKTypeCodeID { get; set; }
        public string PaperworkID { get; set; }
        // external provider
        public string RefProviderID { get; set; }
        public DateTime? ReferralDate { get; set; }
        public string PCPID { get; set; }
        public DateTime? PCPLastSeen { get; set; }
        public string NatureOfConditionID { get; set; }
        public DateTime? LastXRay { get; set; }
        
        // work and accident
        public bool Emergency { get; set; }
        public bool WorkRelated { get; set; }
        public DateTime? DateOfInjury { get; set; }
        public DateTime? InitialTreatmentDate { get; set; }
        public DateTime? DateOfOnset { get; set; }
        public DateTime? SameSimilarSysympton { get; set; }
        public DateTime? AcuteManifestation { get; set; }
        public string DisabilityType { get; set; }
        public DateTime? DisabilityStart { get; set; }
        public DateTime? DisabilityEnd { get; set; }
        public DateTime? LastWorked { get; set; }
        public DateTime? ReturnToWork { get; set; }
        public string AccidentCodeID { get; set; }
        public string AccidentStateID { get; set; }
        public DateTime? AccidentDateTime { get; set; }
      
        // misc
        public string CLIATypeID { get; set; }
        public string CLIANumber { get; set; }
        public string MammographyCert { get; set; }
        public string PriorAuthCode { get; set; }
        public bool Pregnant { get; set; }
        public DateTime? LMP { get; set; }
        public DateTime? EDC { get; set; }
        public string EPSDTCodeID { get; set; }
     
        // system stuff
        public int ChargeBatchID { get; set; }
        public bool ChargeClosed { get; set; }
        public bool ForceToPaper { get; set; }
        public DateTime EntryDateTime { get; set; }
        public string UserID { get; set; }
        public bool ChargePrepped { get; set; }
        public string CurrentPayerCoverageID { get; set; }

        // parents
        public virtual Patient Patient { set; get; }
        public virtual BillingAccount BillingAccount { get; set; }
        public virtual PracticeSite PracticeSite { get; set; }
        public virtual FacilityAdmission FacilityAddmission { get; set; }
        public virtual ExtFacility ExtFacility { get; set; }
        public virtual PWKTransmissionCode PWKTransmissinoCode { get; set; }
        public virtual PWKTypeCode PWKTypeCode { get; set; }
        public virtual ExtProvider RefProvider { get; set; } 
        public virtual ExtProvider PCP { get; set; }
        public virtual NatureOfCondition NatureOfCondition { get; set; }
        public virtual AccidentCode AccidentCode { get; set; }
        public virtual USPSState AccidentState { get; set; }
        public virtual EPSDTCode EPSDTCode { get; set; }
        public virtual ChargeBatch ChargeBatch { get; set; }
        public virtual User User { get; set; }
        public virtual ChargeInsCoverage CurrentPayerCoverage { get; set; }

        //children
        public virtual List<ChargeICD> ChargeICD { get; set; }
        public virtual List<ChargeService> ChargeServices { get; set; }
        public virtual List<ChargeInsCoverage> ChargeInsCoverages { get; set; }
        public virtual List<Claim> Claims { get; set; }
        public virtual List<PrepRequest> PrepRequests { get; set; }
        public virtual List<PrepError> PrepErrors { get; set; }
        public virtual List<PrepRunDetail> PrepRunDetails { get; set; }
        public virtual List<PrepRunPrepError> PrepRunPrepErrors { get; set; }
        public virtual List<PatientNote> PatientNotes { get; set; }
    }
}
