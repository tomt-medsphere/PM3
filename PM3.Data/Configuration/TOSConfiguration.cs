using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class TOSConfiguration : EntityTypeConfiguration<TOS>
    {
        public TOSConfiguration()
        {
            ToTable("TOS");
            HasKey(p => p.TOSId);
            Property(p => p.TOSId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.EDI270s).WithRequired(c => c.TOS);
            HasMany(c => c.Services).WithRequired(c => c.TOS);
        }
    }
}
