using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class Service
    {
        public string ServiceId { get; set; }
        public string ServiceCategoryId { get; set; }
        public string HCPCSId { get; set; }
        public string HCPCSL2Id { get; set; }
        public string RevenueCodeId { get; set; }
        public string Ndc { get; set; }
        public string Description { get; set; }
        public string StatementDescription { get; set; }
        public decimal StandardFee { get; set; }
        public bool Taxable { get; set; }
        public decimal Units { get; set; }
        public string MeasurementUnitId { get; set; }
        public string POSCodeId { get; set; }
        public string TOSCodeId { get; set; }
        public string PracticeNote { get; set; }
        public string BillingNote { get; set; }
        public string NOCNote { get; set; }
        public bool FlashNote { get; set; }
        public string CertficateTypeId { get; set; }
        public bool RequireOrdering { get; set; }
        public bool RequireReferring { get; set; }
        public bool Inactive { get; set; }

        // parents
        public virtual ServiceCategory ServiceCategory { get; set; }
        public virtual HCPCS HCPCS { get; set; }
        public virtual HCPCS HCPCSL2 { get; set; }
        public virtual RevenueCode RevenueCode { get; set; }
        public virtual POS POSCode { get; set; }
        public virtual CertificateType CertificateType { get; set; }

        // children
        public virtual List<ServiceHCPCSModifier> ServiceHCPCSModifiers { get; set; }
    }
}
