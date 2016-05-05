﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class SexConfiguration : EntityTypeConfiguration<Sex>
    {
        public SexConfiguration()
        {
            ToTable("Sex");
            HasKey(p => p.SexId);
            Property(p => p.SexId).IsRequired().HasMaxLength(1);
            Property(p => p.Description).IsRequired().HasMaxLength(100);

            // children
            HasMany(c => c.Persons).WithOptional(c => c.Sex);
        }
    }
}
