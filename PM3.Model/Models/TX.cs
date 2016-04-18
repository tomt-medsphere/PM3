using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class TX
    {
        public int TXID { get; set; }
        public int TXMasterID { get; set; }
        public string ProviderID { get; set; }
        public int ChargeServiceID { get; set; }
        public int ChargeInsCoverageID { get; set; }
        public string InsPlanID { get; set; }
        public string TXCodeID { get; set; }
        public string PaymentFormID { get; set; }
        public decimal Amount { get; set; }
        public decimal Allowed { get; set; }
        public string HCPCSID { get; set; }
        public decimal Units { get; set; }
        public string Note { get; set; }
        public string ICN { get; set; }
        public bool TXClosed { get; set; }
        public string CAGCodeID { get; set; }
        public string CARCodeID { get; set; }
        public DateTime EntryDateTime { get; set; }
        public string UserID { get; set; }

        // parents
        public virtual TXMaster TXMaster { get; set; }
        public virtual ChargeService ChargeService { get; set; }
        public virtual TXCode TXCode { get; set; }
        public virtual PaymentForm PaymentForm { get; set; }
        public virtual User User { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual InsPlan InsPlan { get; set; }
        public virtual CAGCode CAGCode { get; set; }
        public virtual CAR CARCode { get; set; }
        public virtual ChargeInsCoverage ChargeInsCoverage { get; set; }
        public virtual HCPCS HCPCS { get; set; }

        // children
        public virtual List<TXHCPCSModifier> TXHCPCSModifiers { get; set; }
        public virtual List<TXCAS> TXCAS { get; set; }
    }
}
