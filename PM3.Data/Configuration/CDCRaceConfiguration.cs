using PM3.Model.Models;
using System.Data.Entity.ModelConfiguration;

namespace PM3.Data.Configuration
{
    public class CDCRaceConfiguation : EntityTypeConfiguration<CdcRace>
    {
        public CDCRaceConfiguation()
        {
            ToTable("CDCRace");
            HasKey(p => p.CdcRaceId);
            Property(p => p.CdcRaceId).IsRequired().HasMaxLength(10);
            Property(p => p.HCode).IsRequired().HasMaxLength(15);
            Property(p => p.Description).IsRequired().HasMaxLength(100);
            Property(p => p.MuCode).IsRequired().HasMaxLength(10);
        }
    }
}
