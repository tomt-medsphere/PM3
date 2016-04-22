using PM3.Model.Models;
using System.Data.Entity.ModelConfiguration;

namespace PM3.Data.Configuration
{
    public class CARCodeConfiguation : EntityTypeConfiguration<Car>
    {
        public CARCodeConfiguation()
        {
            ToTable("CARe");
            HasKey(p => p.CARId);
            Property(p => p.CARId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(1024);
            Property(p => p.StartDate).IsRequired();
        }
    }
}
