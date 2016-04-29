using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class EDISessionStatusConfiguration : EntityTypeConfiguration<EDISessionStatus>
    {
        public EDISessionStatusConfiguration()
        {
            ToTable("EDISessionStatus");
            HasKey(p => p.EDISessionStatusId);
            Property(p => p.EDISessionStatusId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.EDISessions).WithRequired(c => c.EDISessionStatus);
        }
    }
}
