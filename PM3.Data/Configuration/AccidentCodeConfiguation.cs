using PM3.Model.Models;
using System.Data.Entity.ModelConfiguration;

namespace PM3.Data.Configuration
{
    public class AccidentCodeConfiguation : EntityTypeConfiguration<AccidentCode>
    {
        public AccidentCodeConfiguation()
        {
            ToTable("AccidentCode");
            HasKey(p => p.AccidentCodeId);
            Property(p => p.AccidentCodeId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.Charges).WithOptional(p => p.AccidentCode);
        }
    }
}
