using System.Data.Entity;
using PM3.Model.Models;

namespace PM3.Data
{
    public class Pm3SeedData : DropCreateDatabaseAlways<Pm3Entities>
    {
        protected override void Seed(Pm3Entities context)
        {
            context.AccidentCode.Add(new AccidentCode { AccidentCodeId = "A", Description = "Test Accident Code" });
        }
    }
}
