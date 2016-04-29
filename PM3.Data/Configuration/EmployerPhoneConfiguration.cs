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
    public class EmployerPhoneConfiguration : EntityTypeConfiguration<EmployerPhone>
    {
        public EmployerPhoneConfiguration()
        {
            ToTable("EmployerPhone");
            HasKey(p => p.EmployerPhoneId);
            Property(p => p.EmployerPhoneId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.EmployerId).IsRequired();
            Property(p => p.PhoneId).IsRequired();
            Property(p => p.Sequence).IsRequired();

            // parents
            HasRequired(p => p.Employer).WithMany(p => p.EmployerPhones).HasForeignKey(p => p.EmployerId).WillCascadeOnDelete(false);
            HasRequired(p => p.Phone).WithMany(p => p.EmployerPhones).HasForeignKey(p => p.PhoneId).WillCascadeOnDelete(false);
        }
    }
}
