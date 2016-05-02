using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class MEAReferenceConfiguration : EntityTypeConfiguration<MEAReference>
    {
        public MEAReferenceConfiguration()
        {
            ToTable("MEAReference");
            HasKey(p => p.MEAReferenceId);
            Property(p => p.MEAReferenceId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.ChargeServices).WithOptional(c => c.MEAReference);
        }
    }
}
