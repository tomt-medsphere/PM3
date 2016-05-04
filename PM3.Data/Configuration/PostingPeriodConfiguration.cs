using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class PostingPeriodConfiguration : EntityTypeConfiguration<PostingPeriod>
    {
        public PostingPeriodConfiguration()
        {
            ToTable("PostingPeriod");
            HasKey(p => p.PostingPeriodId);
            Property(p => p.PostingPeriodId).IsRequired().HasMaxLength(10);
            Property(p => p.CreatedUserId).IsRequired().HasMaxLength(255);
            Property(p => p.ClosedUserId).IsOptional().HasMaxLength(255);
            Property(p => p.ClosedDateTime).IsOptional();

            // parents
            HasRequired(p => p.CreatedUser).WithMany(p => p.CreatedPostingPeriods).HasForeignKey(p => p.CreatedUserId).WillCascadeOnDelete(false);
            HasOptional(p => p.ClosedUser).WithMany(p => p.ClosedPostingPeriods).HasForeignKey(p => p.ClosedUserId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.TXBatches).WithOptional(c => c.PostingPeriod);
            HasMany(c => c.ChargeBatches).WithOptional(c => c.PostingPeriod);
        }
    }
}
