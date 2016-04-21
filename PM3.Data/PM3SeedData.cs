using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM3.Model.Models;

namespace PM3.Data
{
    public class PM3SeedData : DropCreateDatabaseAlways<PM3Entities>
    {
        protected override void Seed(PM3Entities context)
        {
            context.AccidentCode.Add(new AccidentCode { AccidentCodeID = "A", Description = "Test Accident Code" });
        }
    }
}
