using PM3.Model.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PM3.Data.Configuration
{
    public class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            ToTable("Person");
            HasKey(p => p.PersonId);
            Property(p => p.PersonId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.LastName).IsRequired().HasMaxLength(25);
            Property(p => p.FirstName).IsRequired().HasMaxLength(25);
            Property(p => p.MiddleName).HasMaxLength(25);
            Property(p => p.SuffixId).IsOptional();
            Property(p => p.SalutationId).IsOptional();
            Property(p => p.Ssn).IsOptional().HasMaxLength(9);
            Property(p => p.Dob).IsOptional();
            Property(p => p.Dod).IsOptional();
            Property(p => p.Deceased).IsOptional();

            HasOptional(p => p.Guardian).WithMany(p => p.Wards).HasForeignKey(p => p.GuardianId).WillCascadeOnDelete(false);
            HasOptional(p => p.EmergencyContact).WithMany(p => p.EmergencyCallers).HasForeignKey(p => p.EmergencyContactId).WillCascadeOnDelete(false);
        }
    }
}
