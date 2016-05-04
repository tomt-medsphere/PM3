using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class PrepRuleConfiguration : EntityTypeConfiguration<PrepRule>
    {
        public PrepRuleConfiguration()
        {
            ToTable("PrepRule");
            HasKey(p => p.PrepRuleId);
            Property(p => p.PrepRuleId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Description).IsRequired().HasMaxLength(100);
            Property(p => p.CheckObject).IsOptional().HasMaxLength(100);
            Property(p => p.CheckProperty).IsOptional().HasMaxLength(100);
            Property(p => p.CheckOperator).IsOptional().HasMaxLength(100);
            Property(p => p.CheckValue).IsOptional().HasMaxLength(100);
            Property(p => p.TestObject).IsOptional().HasMaxLength(100);
            Property(p => p.TestProperty).IsOptional().HasMaxLength(100);
            Property(p => p.TestOperator).IsOptional().HasMaxLength(100);
            Property(p => p.TestValue).IsOptional().HasMaxLength(100);
            Property(p => p.RuleMessage).IsRequired().HasMaxLength(255);
            Property(p => p.Warning).IsRequired();
            Property(p => p.HardCoded).IsRequired();

            // children
            HasMany(c => c.PrepErrors).WithRequired(c => c.PrepRule);
            HasMany(c => c.PrepRunPrepErrors).WithRequired(c => c.PrepRule);
        }
    }
}
