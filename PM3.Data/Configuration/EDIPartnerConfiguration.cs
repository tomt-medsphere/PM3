using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class EDIPartnerConfiguration : EntityTypeConfiguration<EDIPartner>
    {
        public EDIPartnerConfiguration()
        {
            ToTable("EDIPartner");
            HasKey(p => p.EDIPartnerId);
            Property(p => p.EDIPartnerId).IsRequired().HasMaxLength(10);
            Property(p => p.Name).IsRequired().HasMaxLength(60);
            Property(p => p.SubmitterId).IsOptional().HasMaxLength(30);
            Property(p => p.ReceiverId).IsOptional().HasMaxLength(30);
            Property(p => p.Username).IsOptional().HasMaxLength(30);
            Property(p => p.Password).IsOptional().HasMaxLength(30);
            Property(p => p.DUN).IsOptional().HasMaxLength(255);
            Property(p => p.Testing).IsRequired();
            Property(p => p.ContactName).IsOptional().HasMaxLength(100);
            Property(p => p.ContactPhone).IsOptional().HasMaxLength(30);
            Property(p => p.SiteId).IsOptional().HasMaxLength(30);
            Property(p => p.X12Version).IsOptional().HasMaxLength(30);
            Property(p => p.URL).IsOptional().HasMaxLength(255);
            Property(p => p.Note).IsRequired().HasMaxLength(255);
            Property(p => p.ClaimsService).IsRequired();
            Property(p => p.ERAService).IsRequired();
            Property(p => p.EligibilityService).IsRequired();
            Property(p => p.OtherService).IsRequired();
            Property(p => p.Inactive).IsRequired();

            // children
            HasMany(c => c.EDISessions).WithRequired(c => c.EDIPartner);
            HasMany(c => c.Claims).WithOptional(c => c.EDIPartner);
            HasMany(c => c.PrepRunDetails).WithOptional(c => c.EDIPartner);
            HasMany(c => c.ClaimRuns).WithOptional(c => c.EDIPartner);
        }
    }
}
