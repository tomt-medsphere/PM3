using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class IdQualifierConfiguration : EntityTypeConfiguration<IdQualifier>
    {
        public IdQualifierConfiguration()
        {
            ToTable("IdQualifier");
            HasKey(p => p.IdQualifierId);
            Property(p => p.IdQualifierId).IsRequired().HasMaxLength(2);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.InsPlans).WithRequired(c => c.IdQualifier);
        }
    }
}
