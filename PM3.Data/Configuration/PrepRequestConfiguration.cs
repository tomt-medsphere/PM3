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
    public class PrepRequestConfiguration : EntityTypeConfiguration<PrepRequest>
    {
        public PrepRequestConfiguration()
        {
            ToTable("PrepRequest");
            HasKey(p => p.PrepRequestId);
            Property(p => p.PrepRequestId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.ChargeId).IsRequired();
            Property(p => p.ChargeInsCoverageId).IsRequired();
            Property(p => p.UserId).IsRequired();
            Property(p => p.RequestDateTime).IsRequired();

            // parents
            HasRequired(p => p.Charge).WithMany(p => p.PrepRequests).HasForeignKey(p => p.ChargeId).WillCascadeOnDelete(false);
            HasRequired(p => p.ChargeInsCoverage).WithMany(p => p.PrepRequests).HasForeignKey(p => p.ChargeInsCoverageId).WillCascadeOnDelete(false);
            HasRequired(p => p.User).WithMany(p => p.PrepRequests).HasForeignKey(p => p.UserId).WillCascadeOnDelete(false);
        }
    }
}
