﻿using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class InsPlan
    {
        public string InsPlanId { get; set; }
        public string InsPlanGroupId { get; set; }
        public string Name { get; set; }
        public string AddressStreet { get; set; }
        public string AddressOther { get; set; }
        public string City { get; set; }
        public string USPSStateId { get; set; }
        public string PostalCode { get; set; }
        public string USPSCountryId { get; set; }
        public string URL { get; set; }
        public bool Contracted { get; set; }
        public bool AcceptAssignment { get; set; }
        public string InsFormTypeId { get; set; }
        public bool MemberNumbers { get; set; }
        public bool EDIMemberNumbers { get; set; }
        public int TimelyFilingDays { get; set; }
        public bool SubmitZeros { get; set; }
        public bool SupervisedBilling { get; set; }
        public int ICDYearStarts { get; set; }
        public string HPI { get; set; }
        public string EDIPartnerId { get; set; }
        public string ClaimsPayerId { get; set; }
        public string EligibilityPayerId { get; set; }
        public string ClaimFilingIndicatorId { get; set; }
        public string IdQualifierId { get; set; }
        public string MSPTypeId { get; set; }
        public string EDICOBLevelId { get; set; }
        public bool UseHCPCSL2 { get; set; }
        public string Note { get; set; }
        public bool Inactive { get; set; }

        // parents
        public virtual USPSCountry USPSCountry { get; set; }
        public virtual USPSState USPSState { get; set; }
        public virtual IdQualifier IdQualifier { get; set; }
        public virtual InsFormType InsFormType { get; set; }
        public virtual InsPlanGroup InsPlanGroup { get; set; }
        public virtual ClaimFilingIndicator ClaimFilingIndicator { get; set; }
        public virtual EDICOBLevel EDICOBLevel { get; set; }
        public virtual MSPType  MSPType { get; set; }

        // children
        public virtual List<InsPolicy> InsPolicies { get; set; }
        public virtual List<InsPlanCARAction> InsPlanCARActions { get; set; }
        public virtual List<InsPlanPhone> InsPlanPhones { get; set; }
        public virtual List<PlanProfile> PlanProfiles { get; set; }
        public virtual List<Claim> Claims { get; set; }
        public virtual List<PrepRunDetail> PrepRunDetails { get; set; }
        public virtual List<TXBatch> TXBatches { get; set; }
        public virtual List<TX> TXs { get; set; }
    }
}
