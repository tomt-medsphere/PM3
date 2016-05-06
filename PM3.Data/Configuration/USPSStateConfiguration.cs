using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class USPSStateConfiguration : EntityTypeConfiguration<USPSState>
    {
        public USPSStateConfiguration()
        {
            ToTable("USPSState");
            HasKey(p => p.USPSStateId);
            Property(p => p.USPSStateId).IsRequired().HasMaxLength(2);
            Property(p => p.Name).IsRequired().HasMaxLength(50);

            // children
            HasMany(c => c.Charges).WithOptional(c => c.AccidentState);
            HasMany(c => c.Employers).WithOptional(c => c.USPSState);
            HasMany(c => c.ExtFacilities).WithOptional(c => c.USPSState);
            HasMany(c => c.ExtPracticeSites).WithOptional(c => c.USPSState);
            HasMany(c => c.FIPSCounties).WithRequired(c => c.USPSState);
            HasMany(c => c.InsPlans).WithRequired(c => c.USPSState);
            HasMany(c => c.Persons).WithOptional(c => c.USPSState);
            HasMany(c => c.Practices).WithRequired(c => c.USPSState);
            HasMany(c => c.RemitPractices).WithRequired(c => c.RemitUSPSState);
            HasMany(c => c.PracticeSites).WithRequired(c => c.USPSState);
        }
    }
}
