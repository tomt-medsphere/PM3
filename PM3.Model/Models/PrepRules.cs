using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    class PrepRules
    {
        public int PrepRuleID { get; set; }
        public string Description { get; set; }
        public string CheckObject { get; set; }
        public string CheckProperty { get; set; }
        public string CheckOperator { get; set; }
        public string CheckValue { get; set; }
        public string TestObject { get; set; }
        public string TestProperty { get; set; }
        public string TestOperator { get; set; }
        public string TestValue { get; set; }
        public string RuleMessage { get; set; }
        public bool Warning { get; set; }
        public bool HardCoded { get; set; }
    }
}
