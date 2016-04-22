using PM3.Model.Models;
using System.Data.Entity.ModelConfiguration;

namespace PM3.Data.Configuration
{
    public class CDCEthnicityConfiguation : EntityTypeConfiguration<CdcEthnicity>
    {
        public CDCEthnicityConfiguation()
        {
            ToTable("CDCEthnicity");
            HasKey(p => p.CdcEthnicityId);
            Property(p => p.CdcEthnicityId).IsRequired().HasMaxLength(10);
            Property(p => p.HCode).IsRequired().HasMaxLength(15);
            Property(p => p.Description).IsRequired().HasMaxLength(100);
            Property(p => p.MuCode).IsRequired().HasMaxLength(10);
        }
    }
}
