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
    public class FIPSCountyConfiguration : EntityTypeConfiguration<FipsCounty>
    {
        public FIPSCountyConfiguration()
        {
            ToTable("FIPSCounty");
            HasKey(p => p.FIPSCountyId);
            Property(p => p.FIPSCountyId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.USPSStateId).IsRequired().HasMaxLength(2);
            Property(p => p.StateFP).IsRequired().HasMaxLength(2);
            Property(p => p.CountyFP).IsRequired().HasMaxLength(3);
            Property(p => p.CountyName).IsRequired().HasMaxLength(30);
            Property(p => p.ClassFP).IsRequired().HasMaxLength(2);

            // parents
            HasRequired(p => p.USPSState).WithMany(p => p.FIPSCounties);
        }
    }
}
