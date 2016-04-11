using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class User
    {
        public string UserID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SuffixID { get; set; }
        public bool Administrator { get; set; }
        public bool PracticeTables { get; set; }
        public bool Scheduling { get; set; }
        public bool Encounters { get; set; }
        public bool Payments { get; set; }
        public bool Closing { get; set; }
        public string Password { get; set; }
        public bool Inactive { get; set; }
        public bool Management { get; set; }
        public bool PlanProfilesExpert { get; set; }
    }
}
