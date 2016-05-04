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
    public class PracticeSiteConfiguration : EntityTypeConfiguration<PracticeSite>
    {
        public PracticeSiteConfiguration()
        {
            ToTable("PracticeSite");
            HasKey(p => p.PracticeSiteId);
            Property(p => p.PracticeSiteId).IsRequired().HasMaxLength(10);
            Property(p => p.PracticeId).IsRequired().HasMaxLength(10);
            Property(p => p.Name).IsRequired().HasMaxLength(60);
            Property(p => p.CLIATypeId).IsOptional().HasMaxLength(10);
            Property(p => p.CLIANumber).IsOptional().HasMaxLength(10);
            Property(p => p.CLIAExpires).IsOptional();
            Property(p => p.MammographyCertTypeId).IsOptional().HasMaxLength(10);
            Property(p => p.MammographyCertExpires).IsOptional();
            Property(p => p.AddressStreet).IsRequired().HasMaxLength(55);
            Property(p => p.AddressOther).IsRequired().HasMaxLength(55);
            Property(p => p.City).IsRequired().HasMaxLength(30);
            Property(p => p.USPSStateId).IsRequired().HasMaxLength(2);
            Property(p => p.PostalCode).IsRequired().HasMaxLength(15);
            Property(p => p.USPSCountryId).IsRequired().HasMaxLength(2);
            Property(p => p.Inactive).IsRequired();

            // parents
            HasRequired(p => p.Practice).WithMany(p => p.PracticeSites).HasForeignKey(p => p.PracticeId).WillCascadeOnDelete(false);
            HasRequired(p => p.USPSState).WithMany(p => p.PracticeSites).HasForeignKey(p => p.USPSStateId).WillCascadeOnDelete(false);
            HasRequired(p => p.USPSCountry).WithMany(p => p.PracticeSites).HasForeignKey(p => p.USPSCountryId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.PracticeSitePhones).WithRequired(c => c.PracticeSite);
            HasMany(c => c.ChargeBatches).WithOptional(c => c.PracticeSite);
            HasMany(c => c.Charges).WithRequired(c => c.PracticeSite);
            HasMany(c => c.TXBatches).WithOptional(c => c.PracticeSite);
            HasOptional(c => c.PracticeSiteEHR).WithRequired(c => c.PracticeSite);
        }
    }
}
