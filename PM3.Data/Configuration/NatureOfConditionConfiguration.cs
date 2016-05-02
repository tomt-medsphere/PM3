using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class NatureOfConditionConfiguration : EntityTypeConfiguration<NatureOfCondition>
    {
        public NatureOfConditionConfiguration()
        {
            ToTable("NatureOfCondition");
            HasKey(p => p.NatureOfConditionId);
            Property(p => p.NatureOfConditionId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.Charges).WithOptional(c => c.NatureOfCondition);
        }
    }
}
