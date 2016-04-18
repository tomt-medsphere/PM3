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
    public class CAGCodeConfiguation : EntityTypeConfiguration<CAGCode>
    {
        public CAGCodeConfiguation()
        {
            ToTable("CAGCode");
            HasKey(p => p.CAGCodeID);
            Property(p => p.CAGCodeID).IsRequired();
            Property(p => p.Description).IsRequired();
            Property(p => p.StartDate).IsRequired();
        }
    }
}
