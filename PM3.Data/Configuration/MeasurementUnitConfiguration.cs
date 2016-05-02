using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class MeasurementUnitConfiguration : EntityTypeConfiguration<MeasurementUnit>
    {
        public MeasurementUnitConfiguration()
        {
            ToTable("MeasurementUnit");
            HasKey(p => p.MeasurementUnitId);
            Property(p => p.MeasurementUnitId).IsRequired().HasMaxLength(2);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.ChargeServices).WithOptional(c => c.MeasurementUnit);
        }
    }
}
