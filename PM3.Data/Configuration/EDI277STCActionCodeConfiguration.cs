using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class EDI277STCActionCodeConfiguration : EntityTypeConfiguration<EDI277STCActionCode>
    {
        public EDI277STCActionCodeConfiguration()
        {
            ToTable("EDI277ActionCode");
            HasKey(p => p.EDI277STCActionCodeId);
            Property(p => p.EDI277STCActionCodeId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.EDI277STCActions).WithRequired(c => c.EDI277ActionCode);
        }
    }
}
