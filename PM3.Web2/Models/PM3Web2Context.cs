﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PM3.Web2.Models
{
    public class PM3Web2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PM3Web2Context() : base("name=PM3Web2Context")
        {
        }

        public System.Data.Entity.DbSet<PM3.Web2.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<PM3.Model.Models.USPSCountry> USPSCountries { get; set; }
    }
}
