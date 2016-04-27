using PM3.Model.Models;
using System.Data.Entity.ModelConfiguration;

namespace PM3.Data.Configuration
{
    public class CARCodeConfiguation : EntityTypeConfiguration<CARCode>
    {
        public CARCodeConfiguation()
        {
            ToTable("CARCode");
            HasKey(p => p.CARCodeId);
            Property(p => p.CARCodeId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired();
            Property(p => p.StartDate).IsRequired();

            // children
            HasMany(c => c.TX).WithOptional(c => c.CARCode);
            HasMany(c => c.TXCAS).WithRequired(c => c.CARCode);
            HasMany(c => c.InsPlanCARActions).WithRequired(c => c.CARCode);
            HasMany(c => c.CARActions).WithRequired(c => c.CARCode);
        }
    }
}
