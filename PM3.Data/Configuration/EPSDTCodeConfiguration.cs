using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class EPSDTCodeConfiguration : EntityTypeConfiguration<EPSDTCode>
    {
        public EPSDTCodeConfiguration()
        {
            ToTable("EPSDTCode");
            HasKey(p => p.EPSDTCodeId);
            Property(p => p.EPSDTCodeId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.Charges).WithOptional(c => c.EPSDTCode);
        }
    }
}
