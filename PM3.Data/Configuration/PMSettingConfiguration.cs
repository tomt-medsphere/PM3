using PM3.Data.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class PMSettingConfiguration : EntityTypeConfiguration<PMSetting>
    {
        public PMSettingConfiguration()
        {
            ToTable("PMSetting");
            HasKey(p => p.PMSettingId);
            Property(p => p.PMSettingId).IsRequired().HasMaxLength(30);
            Property(p => p.Value1).IsOptional().HasMaxLength(255);
            Property(p => p.Value2).IsOptional().HasMaxLength(255);
            Property(p => p.Value3).IsOptional().HasMaxLength(255);
            Property(p => p.Value4).IsOptional().HasMaxLength(255);
            Property(p => p.Value5).IsOptional().HasMaxLength(255);
            Property(p => p.Value6).IsOptional().HasMaxLength(255);
            Property(p => p.Value7).IsOptional().HasMaxLength(255);
            Property(p => p.Value8).IsOptional().HasMaxLength(255);
            Property(p => p.Value9).IsOptional().HasMaxLength(255);
            Property(p => p.Value10).IsOptional().HasColumnType("longtext");
        }
    }
}
