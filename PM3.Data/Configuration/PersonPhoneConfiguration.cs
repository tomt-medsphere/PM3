using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class PersonPhoneConfiguration : EntityTypeConfiguration<PersonPhone>
    {
        public PersonPhoneConfiguration()
        {
            ToTable("PersonPhone");
            HasKey(p => p.PersonPhoneId);
            Property(p => p.PersonPhoneId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.PersonId).IsRequired();
            Property(p => p.PhoneId).IsRequired();
            Property(p => p.Sequence).IsRequired();
            Property(p => p.Note).IsOptional().HasMaxLength(255);

            // parents
            HasRequired(p => p.Person).WithMany(p => p.PersonPhones).HasForeignKey(p => p.PersonId).WillCascadeOnDelete(false);
            HasRequired(p => p.Phone).WithMany(p => p.PersonPhones).HasForeignKey(p => p.PhoneId).WillCascadeOnDelete(false);
        }
    }
}
