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
    public class PersonRaceConfiguration : EntityTypeConfiguration<PersonRace>
    {
        public PersonRaceConfiguration()
        {
            ToTable("PersonRace");
            HasKey(p => p.PersonRaceId);
            Property(p => p.PersonRaceId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.PersonId).IsRequired();
            Property(p => p.CDCRaceId).IsRequired();
            Property(p => p.Sequence).IsRequired();

            // parents
            HasRequired(p => p.Person).WithMany(p => p.PersonRaces);
            HasRequired(p => p.CDCRace).WithMany(p => p.PersonRaces);
        }
    }
}
