using PM3.Data;
using PM3.Data.Infrastructure;
using PM3.Data.Repositories;
using PM3.Model.Models;
using PM3.Service;
using System;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

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
                if (acs.GetAccidentCode("E") == null)
                {
                    var ac = new AccidentCode
                    {
                        AccidentCodeId = "E",
                        Description = "E description"
                    };
                    acs.CreateAccidentCode(ac);
                    acs.SaveAccidentCode();
                }
                else
                {
                    AccidentCode accidentCode = acs.GetAccidentCode("E");
                    accidentCode.Description = "Some Other New description for E";
                    acs.Update(accidentCode);
                    acs.SaveAccidentCode();

                }

                // list the codes in the table         
                var aclist = acs.GetAccidentCodes();
                foreach (var aci in aclist)
                {
                    Console.WriteLine($"ac: {aci.AccidentCodeId} - {aci.Description}");
                }

                Pm3Entities pe = new Pm3Entities();
                PrepRule pr1 = new PrepRule {Description = "test1"};
                pr1.RuleMessage = "test1";
                pr1.Warning = false;
                pr1.HardCoded = false;

                PrepRule pr2 = new PrepRule();
                pr2.Description = "test2";
                pr2.RuleMessage = "test2";
                pr2.Warning = false;
                pr2.HardCoded = false;


                pe.PrepRule.Add(pr1);
                pe.PrepRule.Add(pr2);

                pe.Commit();


            }
            // all done
            Console.WriteLine("Goodbye from PM3!");
            Console.ReadLine();

           
        }
    }
}
