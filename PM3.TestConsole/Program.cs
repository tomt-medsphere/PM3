using PM3.Data;
using PM3.Data.Infrastructure;
using PM3.Data.Repositories;
using PM3.Model.Models;
using PM3.Service;
using System;

namespace PM3.TestConsole
{
    internal class Program
    {
        private static void Main()
        {
            using (var ctx = new Pm3Entities())
            {
                // create and seed the db
                ctx.Database.Initialize(true);

                // load elements to use AccidentCodeService
                var dbf = new DbFactory();
                var acr = new AccidentCodeRepository(dbf);
                var ui = new UnitOfWork(dbf);
                var acs = new AccidentCodeService(acr, ui);
                
                // add a code to our table
                var ac = new AccidentCode
                {
                    AccidentCodeId = "B",
                    Description = "B description"
                };
                acs.CreateAccidentCode(ac);
                acs.SaveAccidentCode();

                // list the codes in the table         
                var aclist = acs.GetAccidentCodes();
                foreach (var aci in aclist)
                {
                    Console.WriteLine($"ac: {aci.AccidentCodeId} - {aci.Description}");
                }
            }
            // all done
            Console.WriteLine("Goodbye from PM3!");
            Console.ReadLine();

           
        }
    }
}
