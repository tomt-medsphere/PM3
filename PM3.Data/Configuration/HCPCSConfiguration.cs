using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class HCPCSConfiguration : EntityTypeConfiguration<HCPCS>
    {
        public HCPCSConfiguration()
        {
            ToTable("HCPCS");
            HasKey(p => p.HCPCSId);
            Property(p => p.HCPCSId).IsRequired().HasMaxLength(5);

            // children
            HasMany(c => c.HCPCSRVUs).WithRequired(c => c.HCPCS);
            HasMany(c => c.HCPCSServices).WithOptional(c => c.HCPCS);
            HasMany(c => c.HCPCSL2Services).WithOptional(c => c.HCPCSL2);
            HasMany(c => c.HCPCSChargeServices).WithOptional(c => c.HCPCS);
            HasMany(c => c.HCPCSL2ChargeServices).WithOptional(c => c.HCPCSL2);
            HasMany(c => c.TXs).WithOptional(c => c.HCPCS);
        }
    }
}
