using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class Charge
    {
        public int ChargeId { get; set; }
        public int PatientId { get; set; }
        public int BillingAccountId { get; set; }
        public string PracticeSiteId { get; set; }
        public int? FacilityAdmissionId { get; set; }
        public string ExtFacilityId { get; set; }
        public DateTime? AdmitDateTime { get; set; }
        public DateTime? DischargeDateTime { get; set; }
        public string PWKTransmissionCodeId { get; set; }
        public string PWKTypeCodeId { get; set; }
        public string PaperworkId { get; set; }
        // external provider
        public string RefProviderId { get; set; }
        public DateTime? ReferralDate { get; set; }
        public string PCPId { get; set; }
        public DateTime? PCPLastSeen { get; set; }
        public string NatureOfConditionId { get; set; }
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
        public string AccidentCodeId { get; set; }
        public string AccidentStateId { get; set; }
        public DateTime? AccidentDateTime { get; set; }
      
        // misc
        public string CLIATypeId { get; set; }
        public string CLIANumber { get; set; }
        public string MammographyCert { get; set; }
        public string PriorAuthCode { get; set; }
        public bool Pregnant { get; set; }
        public DateTime? LMP { get; set; }
        public DateTime? EDC { get; set; }
        public string EPSDTCodeId { get; set; }
     
        // system stuff
        public int ChargeBatchId { get; set; }
        public bool ChargeClosed { get; set; }
        public bool ForceToPaper { get; set; }
        public DateTime EntryDateTime { get; set; }
        public string UserId { get; set; }
        public bool ChargePrepped { get; set; }
        public int? CurrentPayerCoverageId { get; set; }

        // parents
        public virtual Patient Patient { set; get; }
        public virtual BillingAccount BillingAccount { get; set; }
        public virtual PracticeSite PracticeSite { get; set; }
        public virtual FacilityAdmission FacilityAddmission { get; set; }
        public virtual ExtFacility ExtFacility { get; set; }
        public virtual PWKTransmissionCode PWKTransmissionCode { get; set; }
        public virtual PWKTypeCode PWKTypeCode { get; set; }
        public virtual ExtProvider RefProvider { get; set; } 
        public virtual ExtProvider PCP { get; set; }
        public virtual NatureOfCondition NatureOfCondition { get; set; }
        public virtual AccidentCode AccidentCode { get; set; }
        public virtual USPSState AccidentState { get; set; }
        public virtual EPSDTCode EPSDTCode { get; set; }
        public virtual ChargeBatch ChargeBatch { get; set; }
        public virtual User User { get; set; }

        //children
        public virtual List<ChargeICD> ChargeICDs { get; set; }
        public virtual List<ChargeService> ChargeServices { get; set; }
        public virtual List<ChargeInsCoverage> ChargeInsCoverages { get; set; }
        public virtual List<Claim> Claims { get; set; }
        public virtual List<PrepRequest> PrepRequests { get; set; }
        public virtual List<PrepError> PrepErrors { get; set; }
        public virtual List<PrepRunDetail> PrepRunDetails { get; set; }
        public virtual List<PrepRunPrepError> PrepRunPrepErrors { get; set; }
        public virtual List<PatientNote> PatientNotes { get; set; }
        public virtual List<EDI277STC> EDI277STCs { get; set; }

        // special one to one/zero currentpayercoverage
        public virtual ChargeInsCoverage CurrentPayerCoverage { get; set; }

    }
}
