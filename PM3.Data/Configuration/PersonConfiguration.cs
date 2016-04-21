using PM3.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Data.Configuration
{
    public class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            ToTable("Person");
            HasKey(p => p.PersonID);
            Property(p => p.PersonID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.LastName).IsRequired().HasMaxLength(25);
            Property(p => p.FirstName).IsRequired().HasMaxLength(25);
            Property(p => p.MiddleName).HasMaxLength(25);
            Property(p => p.SuffixID).IsOptional();
            Property(p => p.SalutationID).IsOptional();
            Property(p => p.SSN).IsOptional().HasMaxLength(9);
            Property(p => p.DOB).IsOptional();
            Property(p => p.DOD).IsOptional();
            Property(p => p.Deceased).IsOptional();

            HasOptional(p => p.Guardian).WithMany(p => p.Wards).HasForeignKey(p => p.GuardianID).WillCascadeOnDelete(false);
            HasOptional(p => p.EmergencyContact).WithMany(p => p.EmergencyCallers).HasForeignKey(p => p.EmergencyContactID).WillCascadeOnDelete(false);


        }
    }
}
