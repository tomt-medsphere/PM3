using PM3.Model.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Runtime.CompilerServices;

namespace PM3.Data.Configuration
{
    public class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            ToTable("Person");
            HasKey(p => p.PersonId);
            Property(p => p.PersonId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.LastName).IsRequired().HasMaxLength(60);
            Property(p => p.FirstName).IsRequired().HasMaxLength(35);
            Property(p => p.MiddleName).HasMaxLength(25);
            Property(p => p.SuffixId).IsOptional();
            Property(p => p.SalutationId).IsOptional();
            Property(p => p.SSN).IsOptional().HasMaxLength(9);
            Property(p => p.DOB).IsOptional();
            Property(p => p.DOD).IsOptional();
            Property(p => p.Deceased).IsRequired();
            Property(p => p.SexId).IsOptional().HasMaxLength(1);
            Property(p => p.MaritalStatusId).IsOptional().HasMaxLength(1);
            Property(p => p.LanguageId).IsOptional().HasMaxLength(3);
            Property(p => p.EmailAddress).IsOptional().HasMaxLength(255);
            Property(p => p.EmergencyContactId).IsOptional();
            Property(p => p.EmergencyContactRelationshipCodeId).IsOptional().HasMaxLength(2);
            Property(p => p.EmergencyContactNote).IsOptional().HasColumnType("text");
            Property(p => p.GuardianId).IsOptional();
            Property(p => p.GuardianRelationshipCodeId).IsOptional().HasMaxLength(2);
            Property(p => p.GuardianNote).IsOptional().HasColumnType("text");
            Property(p => p.ResidentialFacilityId).IsOptional().HasMaxLength(10);
            Property(p => p.EmployerId).IsOptional();
            Property(p => p.AKA).IsRequired().HasMaxLength(255);
            Property(p => p.PreferredContactMethod).IsOptional().HasMaxLength(10);
            Property(p => p.MailingAddressStreet).IsOptional().HasMaxLength(55);
            Property(p => p.MailingAddressOther).IsOptional().HasMaxLength(55);
            Property(p => p.MailingAddressCity).IsOptional().HasMaxLength(30);
            Property(p => p.USPSStateId).IsOptional().HasMaxLength(2);
            Property(p => p.PostalCode).IsOptional().HasMaxLength(15);
            Property(p => p.USPSCountryId).IsOptional().HasMaxLength(2);

            // parents
            HasOptional(p => p.Employer).WithMany(p => p.Persons).HasForeignKey(p => p.EmployerId).WillCascadeOnDelete(false);
            HasOptional(p => p.EmergencyContact).WithMany(p => p.EmergencyCallers).HasForeignKey(p => p.EmergencyContactId).WillCascadeOnDelete(false);
            HasOptional(p => p.Guardian).WithMany(p => p.Wards).HasForeignKey(p => p.GuardianId).WillCascadeOnDelete(false);
            HasOptional(p => p.MaritalStatus).WithMany(p => p.Persons).HasForeignKey(p => p.MaritalStatusId).WillCascadeOnDelete(false);
            HasOptional(p => p.Language).WithMany(p => p.Persons).HasForeignKey(p => p.LanguageId).WillCascadeOnDelete(false);
            HasOptional(p => p.EmergencycontactRelationship).WithMany(p => p.EmergencyContactPersons).HasForeignKey(p => p.EmergencyContactRelationshipCodeId).WillCascadeOnDelete(false);
            HasOptional(p => p.GuardianRelationship).WithMany(p => p.GuardianPersons).HasForeignKey(p => p.GuardianRelationshipCodeId).WillCascadeOnDelete(false);
            HasOptional(p => p.USPSState).WithMany(p => p.Persons).HasForeignKey(p => p.USPSStateId).WillCascadeOnDelete(false);
            HasOptional(p => p.USPSCountry).WithMany(p => p.Persons).HasForeignKey(p => p.USPSCountryId).WillCascadeOnDelete(false);
            HasOptional(p => p.Salutation).WithMany(p => p.Persons).HasForeignKey(p => p.SalutationId).WillCascadeOnDelete(false);
            HasOptional(p => p.Suffix).WithMany(p => p.Persons).HasForeignKey(p => p.SuffixId).WillCascadeOnDelete(false);
            HasOptional(p => p.Sex).WithMany(p => p.Persons).HasForeignKey(p => p.SexId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.BillingAccounts).WithRequired(c => c.Guarantor);
            HasMany(c => c.InsPolcies).WithRequired(c => c.Subscriber);
            HasMany(c => c.Patients).WithRequired(c => c.Person);
            HasMany(c => c.PersonPhones).WithRequired(c => c.Person);
            HasMany(c => c.PersonRaces).WithRequired(c => c.Person);
            HasMany(c => c.PersonEthnicities).WithRequired(c => c.Person);
        }
    }
}
