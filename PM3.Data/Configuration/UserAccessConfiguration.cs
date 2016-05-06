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
    public class UserAccessConfiguration : EntityTypeConfiguration<UserAccess>
    {
        public UserAccessConfiguration()
        {
            ToTable("UserAccess");
            HasKey(p => p.UserAccessId);
            Property(p => p.UserAccessId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.UserId).IsRequired().HasMaxLength(255);
            Property(p => p.AccessDateTime).IsRequired();
            Property(p => p.Action).IsRequired().HasMaxLength(10);
            Property(p => p.IPAddress).IsRequired().HasMaxLength(100);
            Property(p => p.Note).IsOptional().HasMaxLength(255);

            // parents
            HasRequired(p => p.User).WithMany(p => p.UserAccesses).HasForeignKey(p => p.UserId).WillCascadeOnDelete(false);
        }
    }
}
