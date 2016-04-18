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
    public class CDCRaceConfiguation : EntityTypeConfiguration<CDCRace>
    {
        public CDCRaceConfiguation()
        {
            ToTable("CDCRace");
            HasKey(p => p.CDCRaceID);
            Property(p => p.CDCRaceID).IsRequired().HasMaxLength(10);
            Property(p => p.HCode).IsRequired().HasMaxLength(15);
            Property(p => p.Description).IsRequired().HasMaxLength(100);
            Property(p => p.MUCode).IsRequired().HasMaxLength(10);
        }
    }
}
