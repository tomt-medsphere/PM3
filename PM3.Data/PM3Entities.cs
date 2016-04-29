using System;
using MySql.Data.Entity;
using PM3.Data.Configuration;
using PM3.Model.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection;
using System.Runtime.InteropServices;

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
        public DbSet<DocumentType> DocumentType { get; set; }

        public virtual void Commit()
        {
            try
            {
                SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine($"exception: {e}");
                Console.ReadLine();
                throw;
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // tweak the Entity Framework conventions
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            // load the configuation classes
            modelBuilder.Configurations.AddFromAssembly(Assembly.Load("PM3.Data"));

            // seed data
            Database.SetInitializer(new Pm3SeedData());
        }

    }
}
