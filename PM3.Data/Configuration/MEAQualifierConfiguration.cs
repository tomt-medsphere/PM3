﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class MEAQualifierConfiguration : EntityTypeConfiguration<MEAQualifier>
    {
        public MEAQualifierConfiguration()
        {
            ToTable("MEAQualifier");
            HasKey(p => p.MEAQualifierId);
            Property(p => p.MEAQualifierId).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.ChargeServices).WithOptional(c => c.MEAQualifier);
        }
    }
}
