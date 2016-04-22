using MySql.Data.Entity;
using PM3.Data.Configuration;
using PM3.Model.Models;
using System.Data.Entity;

namespace PM3.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class Pm3Entities : DbContext
    {
        public DbSet<AccidentCode> AccidentCode { get; set; }

        public virtual void Commit()
        {
            SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // call our Fluent API configutation
            modelBuilder.Configurations.Add(new AccidentCodeConfiguation());

            // seed data
            Database.SetInitializer(new Pm3SeedData());
        }

    }
}
