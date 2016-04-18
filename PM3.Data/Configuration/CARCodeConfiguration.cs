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
    public class CARCodeConfiguation : EntityTypeConfiguration<CAR>
    {
        public CARCodeConfiguation()
        {
            ToTable("CARe");
            HasKey(p => p.CARID);
            Property(p => p.CARID).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(1024);
            Property(p => p.StartDate).IsRequired();
        }
    }
}
