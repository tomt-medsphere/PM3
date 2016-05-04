using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class POSConfiguration : EntityTypeConfiguration<POS>
    {
        public POSConfiguration()
        {
            ToTable("POS");
            HasKey(p => p.POSId);
            Property(p => p.POSId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(255);
            Property(p => p.CMSPOSId).IsRequired().HasMaxLength(2);

            // children
            HasMany(c => c.Services).WithOptional(c => c.POS);
            HasMany(c => c.ChargeServices).WithRequired(c => c.POS);
        }
    }
}
