using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class Tx
    {
        public int TxId { get; set; }
        public int TxMasterId { get; set; }
        public string ProviderId { get; set; }
        public int ChargeServiceId { get; set; }
        public int ChargeInsCoverageId { get; set; }
        public string InsPlanId { get; set; }
        public string TxCodeId { get; set; }
        public string PaymentFormId { get; set; }
        public decimal Amount { get; set; }
        public decimal Allowed { get; set; }
        public string HCPCSId { get; set; }
        public decimal Units { get; set; }
        public string Note { get; set; }
        public string Icn { get; set; }
        public bool TxClosed { get; set; }
        public string CagCodeId { get; set; }
        public string CarCodeId { get; set; }
        public DateTime EntryDateTime { get; set; }
        public string UserId { get; set; }

        // parents
        public virtual TxMaster TxMaster { get; set; }
        public virtual ChargeService ChargeService { get; set; }
        public virtual TxCode TxCode { get; set; }
        public virtual PaymentForm PaymentForm { get; set; }
        public virtual User User { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual InsPlan InsPlan { get; set; }
        public virtual CagCode CagCode { get; set; }
        public virtual Car CarCode { get; set; }
        public virtual ChargeInsCoverage ChargeInsCoverage { get; set; }
        public virtual HCPCS HCPCS { get; set; }

        // children
        public virtual List<TxHCPCSModifier> TxHCPCSModifiers { get; set; }
        public virtual List<TxCAS> TxCAS { get; set; }
    }
}
