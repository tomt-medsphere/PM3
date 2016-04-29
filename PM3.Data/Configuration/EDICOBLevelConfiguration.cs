using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class EDICOBLevelConfiguration : EntityTypeConfiguration<EDICOBLevel>
    {
        public EDICOBLevelConfiguration()
        {
            ToTable("EDICOBLevel");
            HasKey(p => p.EDICOBLevelId);
            Property(p => p.EDICOBLevelId).IsRequired().HasMaxLength(1);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.InsPlans).WithRequired(c => c.EDICOBLevel);
        }
    }
}
