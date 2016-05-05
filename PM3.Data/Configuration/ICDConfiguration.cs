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
    public class ICDConfiguration : EntityTypeConfiguration<ICD>
    {
        public ICDConfiguration()
        {
            ToTable("ICD");
            HasKey(p => p.ICDId);
            Property(p => p.ICDId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.ICDCode).IsRequired().HasMaxLength(10);
            Property(p => p.System).IsRequired().HasMaxLength(10);
            Property(p => p.Version).IsRequired().HasMaxLength(10);
            Property(p => p.Year).IsRequired();
            Property(p => p.FurtherSpecified).IsRequired();
            Property(p => p.Description).IsRequired().HasColumnType("text");
            Property(p => p.MediumDescription).IsRequired().HasMaxLength(60);
            Property(p => p.MediumDescription).IsRequired().HasMaxLength(30);

            // children
            HasMany(c => c.InsPolicyAllowedDxs).WithRequired(c => c.ICD);
            HasMany(c => c.ChargeICDs).WithRequired(c => c.ICD);
            HasMany(c => c.ChargeServiceICDs).WithRequired(c => c.ICD);
        }
    }
}
