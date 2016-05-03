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
    public class PhoneConfiguration : EntityTypeConfiguration<Phone>
    {
        public PhoneConfiguration()
        {
            ToTable("Phone");
            HasKey(p => p.PhoneId);
            Property(p => p.PhoneId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.PhoneTypeId).IsRequired().HasMaxLength(10);
            Property(p => p.ITUCountyId).IsRequired().HasMaxLength(5);
            Property(p => p.AreaCode).IsRequired().HasMaxLength(5);
            Property(p => p.LocalNumber).IsRequired().HasMaxLength(10);
            Property(p => p.Extension).IsOptional().HasMaxLength(10);
            Property(p => p.Note).IsOptional().HasMaxLength(255);

            // parents
            HasRequired(p => p.PhoneType).WithMany(p => p.Phones).HasForeignKey(p => p.PhoneTypeId).WillCascadeOnDelete(false);
            HasRequired(p => p.ITUCountry).WithMany(p => p.Phones).HasForeignKey(p => p.ITUCountyId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.ExtPracticeSitePhones).WithRequired(c => c.Phone);
            HasMany(c => c.ExtProviderPhones).WithRequired(c => c.Phone);
            HasMany(c => c.ExtFacilityPhones).WithRequired(c => c.Phone);
            HasMany(c => c.PracticePhones).WithRequired(c => c.Phone);

        }
    }
}
