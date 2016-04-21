using PM3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new PM3Entities())
            {
                ctx.Database.Initialize(true);
            }
            Console.WriteLine("hello from PM3!");
            Console.ReadLine();

           
        }
    }
}
