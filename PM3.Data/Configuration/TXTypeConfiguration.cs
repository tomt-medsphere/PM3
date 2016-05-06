using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class TXTypeConfiguration : EntityTypeConfiguration<TXType>
    {
        public TXTypeConfiguration()
        {
            ToTable("TXType");
            HasKey(p => p.TXTypeId);
            Property(p => p.TXTypeId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.TXCodes).WithRequired(c => c.TXType);
        }
    }
}
