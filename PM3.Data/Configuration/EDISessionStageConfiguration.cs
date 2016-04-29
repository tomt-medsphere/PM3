using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class EDISessionStageConfiguration : EntityTypeConfiguration<EDISessionStage>
    {
        public EDISessionStageConfiguration()
        {
            ToTable("EDISessionStage");
            HasKey(p => p.EDISessionStageId);
            Property(p => p.EDISessionStageId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.EDISessionSteps).WithRequired(c => c.EDISessionStage);
        }
    }
}
