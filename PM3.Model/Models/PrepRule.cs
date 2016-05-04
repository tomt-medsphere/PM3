using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class PrepRule
    {
        public int PrepRuleId { get; set; }
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

        // children
        public virtual List<PrepError> PrepErrors { get; set; }
        public virtual List<PrepRunPrepError> PrepRunPrepErrors { get; set; }
    }
}
