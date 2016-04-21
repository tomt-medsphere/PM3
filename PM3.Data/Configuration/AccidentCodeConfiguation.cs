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
    public class AccidentCodeConfiguation : EntityTypeConfiguration<AccidentCode>
    {
        public AccidentCodeConfiguation()
        {
            ToTable("AccidentCode");
            HasKey(p => p.AccidentCodeID);
            Property(p => p.AccidentCodeID).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(60);

            // children
            //HasMany(c => c.Charges).WithOptional(p => p.AccidentCode);
        }
    }
}
