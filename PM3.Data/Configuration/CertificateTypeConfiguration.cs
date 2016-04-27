using PM3.Model.Models;
using System.Data.Entity.ModelConfiguration;

namespace PM3.Data.Configuration
{
    public class CertificateTypeConfiguation : EntityTypeConfiguration<CertificateType>
    {
        public CertificateTypeConfiguation()
        {
            ToTable("CertificateType");
            HasKey(p => p.CertificateTypeId);
            Property(p => p.CertificateTypeId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.ChargeServices).WithOptional(c => c.CertificateType);
            HasMany(c => c.Services).WithOptional(c => c.CertificateType);
        }
    }
}
