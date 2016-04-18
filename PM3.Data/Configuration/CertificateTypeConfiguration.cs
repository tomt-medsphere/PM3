using PM3.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Data.Configuration
{
    public class CertificateTypeConfiguation : EntityTypeConfiguration<CertificateType>
    {
        public CertificateTypeConfiguation()
        {
            ToTable("CertificateType");
            HasKey(p => p.CertificateTypeID);
            Property(p => p.CertificateTypeID).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(30);
        }
    }
}
