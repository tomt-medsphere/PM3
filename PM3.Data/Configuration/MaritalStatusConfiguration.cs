using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class MaritalStatusConfiguration : EntityTypeConfiguration<MaritalStatus>
    {
        public MaritalStatusConfiguration()
        {
            ToTable("MaritalStatus");
            HasKey(p => p.MaritalStatusId);
            Property(p => p.MaritalStatusId).IsRequired().HasMaxLength(1);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.Persons).WithOptional(c => c.MaritalStatus);
        }
    }
}
