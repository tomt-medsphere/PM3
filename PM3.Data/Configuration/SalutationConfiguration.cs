﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data.Configuration
{
    public class SalutationConfiguration : EntityTypeConfiguration<Salutation>
    {
        public SalutationConfiguration()
        {
            ToTable("Salutation");
            HasKey(p => p.SalutationId);
            Property(p => p.SalutationId).IsRequired().HasMaxLength(10);

            // children
            HasMany(c => c.Persons).WithOptional(c => c.Salutation);
        }
    }
}
