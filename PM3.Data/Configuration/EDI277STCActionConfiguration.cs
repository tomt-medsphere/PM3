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
    public class EDI277STCActionConfiguration : EntityTypeConfiguration<EDI277STCAction>
    {
        public EDI277STCActionConfiguration()
        {
            ToTable("EDI277STCAction");
            HasKey(p => p.EDI277STCActionId);
            Property(p => p.EDI277STCActionId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.EDI277STCId).IsRequired();
            Property(p => p.UserId).IsRequired().HasMaxLength(255);
            Property(p => p.EDI277ActionCodeId).IsRequired().HasMaxLength(10);
            Property(p => p.ActionDateTime).IsRequired();
            Property(p => p.Note).IsOptional();

            // parents
            HasRequired(p => p.User).WithMany(p => p.EDI277Actions).HasForeignKey(p => p.UserId).WillCascadeOnDelete(false);
            HasRequired(p => p.EDI277ActionCode).WithMany(p => p.EDI277STCActions).HasForeignKey(p => p.EDI277ActionCodeId).WillCascadeOnDelete(false);
            HasRequired(p => p.EDI277STC).WithMany(p => p.EDI277STCActions).HasForeignKey(p => p.EDI277STCId).WillCascadeOnDelete(false);
        }
    }
}
