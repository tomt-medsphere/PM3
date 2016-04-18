using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class Service
    {
        public string ServiceID { get; set; }
        public string ServiceCategoryID { get; set; }
        public string HCPCSID { get; set; }
        public string HCPCSL2ID { get; set; }
        public string RevenueCodeID { get; set; }
        public string NDC { get; set; }
        public string Description { get; set; }
        public string StatementDescription { get; set; }
        public decimal StandardFee { get; set; }
        public bool Taxable { get; set; }
        public decimal Units { get; set; }
        public string MeasurementUnitID { get; set; }
        public string POSCodeID { get; set; }
        public string TOSCodeID { get; set; }
        public string PracticeNote { get; set; }
        public string BillingNote { get; set; }
        public string NOCNote { get; set; }
        public bool FlashNote { get; set; }
        public string CertficateTypeID { get; set; }
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
