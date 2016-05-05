using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class RARCConfiguration : EntityTypeConfiguration<RARC>
    {
        public RARCConfiguration()
        {
            ToTable("RARC");
            HasKey(p => p.RARCId);
            Property(p => p.RARCId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasColumnType("text");

            // children
            HasMany(c => c.TXMasterRARCs).WithRequired(c => c.RARC);
        }
    }
}
