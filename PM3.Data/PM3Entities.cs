using MySql.Data.Entity;
using PM3.Data.Configuration;
using PM3.Model.Models;
using System.Data.Entity;
using System.Reflection;

namespace PM3.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class Pm3Entities : DbContext
    {
        public Pm3Entities() : base("Pm3Entities")
        {
        }

        public DbSet<AccidentCode> AccidentCode { get; set; }
        public DbSet<DocumentCategory> DocumentCategory { get; set; }

        public virtual void Commit()
        {
            SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            // load the configuation classes
            modelBuilder.Configurations.AddFromAssembly(Assembly.Load("PM3.Data"));

            // seed data
            Database.SetInitializer(new Pm3SeedData());
        }

    }
}
