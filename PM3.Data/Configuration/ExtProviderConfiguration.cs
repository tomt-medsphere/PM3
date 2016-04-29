using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class ExtProviderConfiguration : EntityTypeConfiguration<ExtProvider>
    {
        public ExtProviderConfiguration()
        {
            ToTable("ExtProvider");
            HasKey(p => p.ExtProviderId);
            Property(p => p.ExtProviderId).IsRequired().HasMaxLength(10);
            Property(p => p.LastName).IsRequired().HasMaxLength(60);
            Property(p => p.FirstName).IsRequired().HasMaxLength(35);
            Property(p => p.MiddleName).IsOptional().HasMaxLength(25);
            Property(p => p.SuffixId).IsOptional().HasMaxLength(10);
            Property(p => p.Credentials).IsOptional().HasMaxLength(10);
            Property(p => p.NPI).IsOptional().HasMaxLength(10);
            Property(p => p.TaxonomyCodeId).IsOptional().HasMaxLength(15);
            Property(p => p.CMSSpecialityId).IsOptional().HasMaxLength(10);
            Property(p => p.ExtPracticeId).IsOptional();
            Property(p => p.ExtPracticeSiteId).IsOptional();
            Property(p => p.Inactive).IsRequired();

            // parents
            HasOptional(p => p.ExtPractice).WithMany(p => p.ExtProviders).HasForeignKey(p => p.ExtPracticeId).WillCascadeOnDelete(false);
            HasOptional(p => p.ExtPracticeSite).WithMany(p => p.ExtProviders).HasForeignKey(p => p.ExtPracticeSiteId).WillCascadeOnDelete(false);
            HasOptional(p => p.TaxonomyCode).WithMany(p => p.ExtProviders).HasForeignKey(p => p.TaxonomyCodeId).WillCascadeOnDelete(false);
            HasOptional(p => p.CMSSpeciality).WithMany(p => p.ExtProviders).HasForeignKey(p => p.CMSSpecialityId).WillCascadeOnDelete(false);
            HasOptional(p => p.Suffix).WithMany(p => p.ExtProviders).HasForeignKey(p => p.SuffixId).WillCascadeOnDelete(false);

            // children
            HasMany(c => c.PCPPatients).WithOptional(c => c.PCP);
            //HasMany(c => c.ExtProviderPhones).WithRequired(c => c.ExtProvider);
            HasMany(c => c.RefCharges).WithOptional(c => c.RefProvider);
            HasMany(c => c.PCPCharges).WithOptional(c => c.PCP);
            HasMany(c => c.OrderingChargeServices).WithOptional(c => c.OrderingProvider);
        }
    }
}
