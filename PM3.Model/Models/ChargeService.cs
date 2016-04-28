using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class ChargeService
    {
        public int ChargeServiceId { get; set; }
        public int ChargeId { get; set; }
        public int PatientId { get; set; }
        public int BillingAccountId { get; set; }
        public int Sequence { get; set; }
        public DateTime DateOfServiceStart { get; set; }
        public DateTime? DateOfServiceEnd { get; set; }
        public string ServiceId { get; set; }
        public string Description { get; set; }
        public string StatementDescription { get; set; }
        public string HCPCSId { get; set; }
        public string HCPCSL2Id { get; set; }
        public decimal Units { get; set; }
        public decimal Fee { get; set; }
        public string POSId { get; set; }
        public string BillingNote { get; set; }
        public string CertificateTypeId { get; set; }
        public string RenderingProviderId { get; set; }
        public string SupervisingProviderId { get; set; }
        public string OrderingProviderId { get; set; }
        public bool AcceptAssignment { get; set; }
        public bool PayProvider { get; set; }
        public bool BillInsurance { get; set; }
        public bool Taxable { get; set; }
        public string NDC { get; set; }
        public string MEAReferenceId { get; set; }
        public string MEAQualifierId { get; set; }
        public string MeasurementUnitId { get; set; }
        public string MEAValue { get; set; }
        public bool StatementClosed { get; set; }
        public decimal Balance { get; set; }
        public decimal? StatementBalance { get; set; }
        public bool ChargeClosed { get; set; }
        public string ChargeServiceStatusId { get; set; }
        public DateTime ChargeServiceStatusDate { get; set; }

        // parents
        public virtual Charge Charge { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual BillingAccount BillingAccount { get; set; }
        public virtual Service Service { get; set; }
        public virtual HCPCS HCPCS { get; set; }
        public virtual HCPCS HCPCSL2 { get; set; }
        public virtual POS POS { get; set; }
        public virtual CertificateType CertificateType { get; set; }
        public virtual Provider RenderingProvider { get; set; }
        public virtual Provider SupervisingProvider { get; set; }
        public virtual ExtProvider OrderingProvider { get; set; }
        public virtual MEAReference MEAReference { get; set; }
        public virtual MEAQualifier MEAQualifier { get; set; }
        public virtual MeasurementUnit MeasurementUnit { get; set; }
        public virtual ChargeServiceStatus ChargeServiceStatus { get; set; }

        // children
        public virtual List<ChargeServiceMod> ChargeServiceMods { get; set; }
        public virtual List<ChargeServiceICD> ChargeServiceICDs { get; set; }
        public virtual List<PrepError> PrepErrors { get; set; }
        public virtual List< PrepRunPrepError> PrepRunPrepErrors { get; set; }
        public virtual List<TX> TXs { get; set; }
        public virtual List<EDI277STC> EDI277STCs { get; set; }
    }
}
