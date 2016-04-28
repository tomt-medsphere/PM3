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
    public class ChargeInsCoverageConfiguration : EntityTypeConfiguration<ChargeInsCoverage>
    {
        public ChargeInsCoverageConfiguration()
        {
            ToTable("ChargeInsCoverage");
            HasKey(p => p.ChargeInsCoverageId);
            Property(p => p.ChargeInsCoverageId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.ChargeId).IsRequired();
            Property(p => p.InsCoverageId).IsRequired();
            Property(p => p.Sequence).IsRequired();
            Property(p => p.Inactive).IsRequired();

            // parents
            HasRequired(p => p.InsCoverage).WithMany(p => p.ChargeInsCoverages).HasForeignKey(p => p.InsCoverageId).WillCascadeOnDelete(false);
            HasRequired(p => p.Charge).WithMany(p => p.ChargeInsCoverages).HasForeignKey(p => p.ChargeId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.PrepErrors).WithRequired(c => c.ChargeInsCoverage);
            HasMany(c => c.Claims).WithRequired(c => c.ChargeInsCoverage);
            HasMany(c => c.PrepRequests).WithRequired(c => c.ChargeInsCoverage);
            HasMany(c => c.PrepRunPrepErrors).WithRequired(c => c.ChargeInsCoverage);
            HasMany(c => c.TXs).WithOptional(c => c.ChargeInsCoverage);

            // special one to one/zero currentpayercoverage
            HasOptional(c => c.CurrentPayerCoverage).WithOptionalDependent(c => c.CurrentPayerCoverage);
        }
    }
}
