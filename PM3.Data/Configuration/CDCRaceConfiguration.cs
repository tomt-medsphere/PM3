using PM3.Model.Models;
using System.Data.Entity.ModelConfiguration;

namespace PM3.Data.Configuration
{
    public class CDCRaceConfiguation : EntityTypeConfiguration<CDCRace>
    {
        public CDCRaceConfiguation()
        {
            ToTable("CDCRace");
            HasKey(p => p.CDCRaceId);
            Property(p => p.CDCRaceId).IsRequired().HasMaxLength(10);
            Property(p => p.HCode).IsRequired().HasMaxLength(15);
            Property(p => p.Description).IsRequired().HasMaxLength(100);
            Property(p => p.MuCode).IsRequired().HasMaxLength(10);

            // children
            HasMany(c => c.PersonRaces).WithRequired(c => c.CDCRace);
        }
    }
}
