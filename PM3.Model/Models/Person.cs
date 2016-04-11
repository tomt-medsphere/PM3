using PM3.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SuffixID { get; set; }
        public string SalutationID { get; set; }
        public string SSN { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOD { get; set; }
        public bool Deceased { get; set; }
        public string SexID { get; set; }
        public string MaritalStatusID { get; set; }
        public string LanguageID { get; set; }
        public string CDCRaceID { get; set; }
        public string CDCEthnicityID { get; set; }
        public string EmailAddress { get; set; }
        public int EmergencyContactID { get; set; }
        public string EmergencyContactRelationshipCodeID { get; set; }
        public string EmergencyContactNote { get; set; }
        public int GuardianID { get; set; }
        public string GuardianRelationshipCodeID { get; set; }
        public String GuardianNote { get; set; }
        public string ResidentialFacilityID { get; set; }
        public int EmployerID { get; set; }
        public string AKA { get; set; }
        public string PreferredContactMethod { get; set; }
        public string MailingAddressStreet { get; set; }
        public string MailingAddressOther { get; set; }
        public string MailingAddressCity { get; set; }
        public string USPSStateID { get; set; }
        public string PostalCode { get; set; }
        public string USPSCountryID { get; set; }

        public virtual Employer Employer { get; set;}
        public virtual Person EmergencyContact { get; set; }
        public virtual RelationshipCode EmergencycontactRelationship { get; set; }
        public virtual Person Guardian { get; set; }
        public virtual RelationshipCode GuardianRelationship { get; set; }
        public virtual MaritalStatus MaritalStatus { get; set; }
        public virtual Language Language { get; set; }
        public virtual CDCRace CDCRace { get; set; }
        public virtual  CDCEthnicity CDCEthnicity { get; set; }
        public virtual USPSState USPSState { get; set; }
        public virtual USPSCountry USPSCountry { get; set; }
        public virtual Salutation Salutation { get; set; }
        public virtual Suffix Suffix { get; set; }
    }
}
