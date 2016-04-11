using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class InsPlan
    {
        public string InsPlanID { get; set; }
        public string InsPlanGroupID { get; set; }
        public string Name { get; set; }
        public string AddressStreet { get; set; }
        public string AddressOther { get; set; }
        public string AddressCity { get; set; }
        public string USPSStateID { get; set; }
        public string PostalCode { get; set; }
        public string USPSCountryID { get; set; }
        public string URL { get; set; }
        public bool Contracted { get; set; }
        public bool AcceptAssignment { get; set; }
        public string InsFormTypeID { get; set; }
        public bool MemberNumbers { get; set; }
        public bool EDIMemberNumbers { get; set; }
        public int TimelyFilingDays { get; set; }
        public bool SubmitZeros { get; set; }
        public bool SupervisedBilling { get; set; }
        public int ICDYearStarts { get; set; }
        public string HPI { get; set; }
        public string EDIPartnerID { get; set; }
        public string ClaimsPayerID { get; set; }
        public string EligibilityPayerID { get; set; }
        public string ClaimFilingIndicatorID { get; set; }
        public string IDQualifierID { get; set; }
        public string MSPTypeID { get; set; }
        public string EDICOBLevelID { get; set; }
        public bool UseHCPCSL2 { get; set; }
        public bool Inactive { get; set; }
        public string Note { get; set; }

        public virtual USPSCountry USPSCountry { get; set; }
        public virtual USPSState USPSState { get; set; }
        public virtual IDQualifier IDQualifier { get; set; }
        public virtual InsFormType InsFormType { get; set; }
        public virtual InsPlanGroup InsPlanGroup { get; set; }
        public virtual ClaimFilingIndicator ClaimFilingIndicator { get; set; }
        public virtual EDICOBLevel EDICOBLevel { get; set; }
        public virtual MSPType  MSPType { get; set; }
    }
}
