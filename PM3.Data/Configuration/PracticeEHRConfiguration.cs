using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class PracticeEHRConfiguration : EntityTypeConfiguration<PracticeEHR>
    {
        public PracticeEHRConfiguration()
        {
            ToTable("PracticeEHR");
            HasKey(p => p.PracticeId);
            Property(p => p.PracticeId).IsRequired();

            // parent
            HasRequired(p => p.Practice).WithOptional(p => p.PracticeEHR);
        }
    }
}
