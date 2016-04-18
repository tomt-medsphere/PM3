using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class ChargeService
    {
        public int ChargeServiceID { get; set; }
        public int ChargeID { get; set; }
        public int PatientID { get; set; }
        public int BillingAccountID { get; set; }
        public int Sequence { get; set; }
        public DateTime DateOfServiceStart { get; set; }
        public DateTime? DateOfServiceEnd { get; set; }
        public string ServiceID { get; set; }
        public string Description { get; set; }
        public string StatementDescription { get; set; }
        public string HCPCSID { get; set; }
        public string HCPCSL2ID { get; set; }
        public decimal Units { get; set; }
        public decimal Fee { get; set; }
        public string POSID { get; set; }
        public string BillingNote { get; set; }
        public string CertificateTypeID { get; set; }
        public string RenderingProviderID { get; set; }
        public string SupervisingProviderID { get; set; }
        public string OrderingProviderID { get; set; }
        public bool AcceptAssignment { get; set; }
        public bool PayProvider { get; set; }
        public bool BillInsurance { get; set; }
        public bool Taxable { get; set; }
        public string NDC { get; set; }
        public string MEAReferenceID { get; set; }
        public string MEAQualifierID { get; set; }
        public string MeasurementUnitID { get; set; }
        public string MEAValue { get; set; }
        public bool StatementClosed { get; set; }
        public decimal Balance { get; set; }
        public decimal? StatementBalance { get; set; }
        public bool ChargeClosed { get; set; }
        public string ChargeServiceStatusID { get; set; }
        public DateTime ChargeServiceStatudDate { get; set; }

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
        public virtual List<ChargeServiceICD> ChargeServiceICD { get; set; }
        public virtual List<PrepError> PrepErrors { get; set; }
        public virtual List< PrepRunPrepError> PrepRunPrepErrors { get; set; }
        public virtual List<TX> TX { get; set; }
        public virtual List<EDI277STC> EDI277STC { get; set; }
    }
}
