using System;
using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SuffixId { get; set; }
        public string SalutationId { get; set; }
        public string SSN { get; set; }
        public DateTime? DOB { get; set; }
        public DateTime? DOD { get; set; }
        public bool Deceased { get; set; }
        public string SexId { get; set; }
        public string MaritalStatusId { get; set; }
        public string LanguageId { get; set; }
        public string CDCRaceId { get; set; }
        public string CDCEthnicityId { get; set; }
        public string EmailAddress { get; set; }
        public int? EmergencyContactId { get; set; }
        public string EmergencyContactRelationshipCodeId { get; set; }
        public string EmergencyContactNote { get; set; }
        public int? GuardianId { get; set; }
        public string GuardianRelationshipCodeId { get; set; }
        public string GuardianNote { get; set; }
        public string ResidentialFacilityId { get; set; }
        public int? EmployerId { get; set; }
        public string AKA { get; set; }
        public string PreferredContactMethod { get; set; }
        public string MailingAddressStreet { get; set; }
        public string MailingAddressOther { get; set; }
        public string MailingAddressCity { get; set; }
        public string USPSStateId { get; set; }
        public string PostalCode { get; set; }
        public string USPSCountryId { get; set; }

        //parents
        public virtual Employer Employer { get; set;}
        public virtual Person EmergencyContact { get; set; }
        public virtual RelationshipCode EmergencycontactRelationship { get; set; }
        public virtual Person Guardian { get; set; }
        public virtual RelationshipCode GuardianRelationship { get; set; }
        public virtual MaritalStatus MaritalStatus { get; set; }
        public virtual Language Language { get; set; }
        public virtual CDCRace CDCRace { get; set; }
        public virtual CDCEthnicity CDCEthnicity { get; set; }
        public virtual USPSState USPSState { get; set; }
        public virtual USPSCountry USPSCountry { get; set; }
        public virtual Salutation Salutation { get; set; }
        public virtual Suffix Suffix { get; set; }
        public virtual Sex Sex { get; set; }

        // children
        public virtual List<BillingAccount> BillingAccounts { get; set; }
        public virtual List<InsPolicy> InsPolcies { get; set; }
        public virtual List<Patient> Patients { get; set; }
        public virtual List<PersonPhone> PersonPhones { get; set; }
        public virtual List<PersonRace> PersonRaces { get; set; }
        public virtual List<PersonEthnicity> PersonEthnicities { get; set; }
        public virtual List<Person> Wards { get; set; }
        public virtual List<Person> EmergencyCallers { get; set; }

    }
}
