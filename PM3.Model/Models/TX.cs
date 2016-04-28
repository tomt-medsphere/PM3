using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class TX
    {
        public int TXId { get; set; }
        public int TXMasterId { get; set; }
        public string ProviderId { get; set; }
        public int ChargeServiceId { get; set; }
        public int? ChargeInsCoverageId { get; set; }
        public string InsPlanId { get; set; }
        public string TxCodeId { get; set; }
        public string PaymentFormId { get; set; }
        public decimal Amount { get; set; }
        public decimal Allowed { get; set; }
        public string HCPCSId { get; set; }
        public decimal Units { get; set; }
        public string Note { get; set; }
        public string Icn { get; set; }
        public bool TXClosed { get; set; }
        public string CAGCodeId { get; set; }
        public string CARCodeId { get; set; }
        public DateTime EntryDateTime { get; set; }
        public string UserId { get; set; }

        // parents
        public virtual TXMaster TXMaster { get; set; }
        public virtual ChargeService ChargeService { get; set; }
        public virtual TXCode TxCode { get; set; }
        public virtual PaymentForm PaymentForm { get; set; }
        public virtual User User { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual InsPlan InsPlan { get; set; }
        public virtual CAGCode CAGCode { get; set; }
        public virtual CARCode CARCode { get; set; }
        public virtual ChargeInsCoverage ChargeInsCoverage { get; set; }
        public virtual HCPCS HCPCS { get; set; }

        // children
        public virtual List<TXHCPCSModifier> TXHCPCSModifiers { get; set; }
        public virtual List<TXCAS> TXCAS { get; set; }
    }
}
