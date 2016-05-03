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
    public class PersonEthnicityConfiguration : EntityTypeConfiguration<PersonEthnicity>
    {
        public PersonEthnicityConfiguration()
        {
            ToTable("PersonEthnicity");
            HasKey(p => p.PersonEthnicityId);
            Property(p => p.PersonEthnicityId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.PersonId).IsRequired();
            Property(p => p.CDCEthnicityId).IsRequired().HasMaxLength(10);
            Property(p => p.Sequence).IsRequired();

            // parents
            HasRequired(p => p.Person).WithMany(p => p.PersonEthnicities).HasForeignKey(p => p.PersonId).WillCascadeOnDelete(false);
            HasRequired(p => p.CDCEthnicity).WithMany(p => p.PersonEthnicities).HasForeignKey(p => p.CDCEthnicityId).WillCascadeOnDelete(false);
        }
    }
}
