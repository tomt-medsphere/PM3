using PM3.Model.Models;
using System.Data.Entity.ModelConfiguration;

namespace PM3.Data.Configuration
{
    public class CAGCodeConfiguation : EntityTypeConfiguration<CagCode>
    {
        public CAGCodeConfiguation()
        {
            ToTable("CAGCode");
            HasKey(p => p.CagCodeId);
            Property(p => p.CagCodeId).IsRequired();
            Property(p => p.Description).IsRequired();
            Property(p => p.StartDate).IsRequired();
        }
    }
}
