using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class InsPlanCARActionConfiguration : EntityTypeConfiguration<InsPlanCARAction>
    {
        public InsPlanCARActionConfiguration()
        {
            ToTable("InsPlanCARAction");
            HasKey(p => p.InsPlanCARActionId);
            Property(p => p.InsPlanCARActionId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.CARCodeId).IsRequired().HasMaxLength(10);
            Property(p => p.InsPlanId).IsRequired().HasMaxLength(10);
            Property(p => p.ShortDescription).IsOptional().HasMaxLength(60);
            Property(p => p.SetReviewStatus).IsRequired();
            Property(p => p.CreateTxNote).IsRequired();
            Property(p => p.StartDate).IsRequired();
            Property(p => p.EndDate).IsOptional();

            // parents
            HasRequired(p => p.CARCode).WithMany(p => p.InsPlanCARActions).HasForeignKey(p => p.CARCodeId).WillCascadeOnDelete(false);
            HasRequired(p => p.InsPlan).WithMany(p => p.InsPlanCARActions).HasForeignKey(p => p.InsPlanId).WillCascadeOnDelete(false);
        }
    }
}
