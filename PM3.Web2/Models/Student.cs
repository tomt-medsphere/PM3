using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PM3.Web2.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public bool Active { get; set; }
    }
}