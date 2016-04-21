using MySql.Data.Entity;
using PM3.Data.Configuration;
using PM3.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class PM3Entities : DbContext
    {
        public PM3Entities() : base()
        {
        }

        public DbSet<AccidentCode> AccidentCode { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // call our Fluent API configutation
            modelBuilder.Configurations.Add(new AccidentCodeConfiguation());

            // seed data
            System.Data.Entity.Database.SetInitializer(new PM3SeedData());
        }

    }
}
