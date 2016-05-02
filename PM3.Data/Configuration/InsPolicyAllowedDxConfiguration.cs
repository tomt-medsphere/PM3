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
    public class InsPolicyAllowedDxConfiguration : EntityTypeConfiguration<InsPolicyAllowedDX>
    {
        public InsPolicyAllowedDxConfiguration()
        {
            ToTable("InsPolicyAllowedDX");
            HasKey(p => p.InsPolicyAllowedDXId);
            Property(p => p.InsPolicyAllowedDXId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.InsPolicyId).IsRequired();
            Property(p => p.ICDId).IsRequired();
            Property(p => p.Sequence).IsRequired();

            // parents
            HasRequired(p => p.InsPolicy).WithMany(p => p.InsPolicyAllowedDXs).HasForeignKey(p => p.InsPolicyId).WillCascadeOnDelete(false);
            HasRequired(p => p.ICD).WithMany(p => p.InsPolicyAllowedDxs).HasForeignKey(p => p.ICDId).WillCascadeOnDelete(false);
        }
    }
}
