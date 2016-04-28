using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class ChargeServiceStatusConfiguration : EntityTypeConfiguration<ChargeServiceStatus>
    {
        public ChargeServiceStatusConfiguration()
        {
            ToTable("ChargeServiceStatus");
            HasKey(p => p.ChargeServiceStatusId);
            Property(p => p.ChargeServiceStatusId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.ChargeServices).WithRequired(c => c.ChargeServiceStatus);
        }
    }
}
