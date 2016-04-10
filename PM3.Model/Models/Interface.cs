using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PM3.Model.Models
{
    public class Interface
    {
        public int InterfaceID { get; set; }
        public string Description { get; set; }
        public string Protocol { get; set; }
        public string Version { get; set; }
        public string SendingApplication { get; set; }
        public string SendintFacility { get; set; }
        public string ReceivingApplication { get; set; }
        public string ReceivingFacility { get; set; }
        public string MessageType { get; set; }
        public string EventType { get; set; }
        public string FieldSeperator { get; set; }
        public string ComponentSeperator { get; set; }
        public string SubComponentSeperator { get; set; }
        public string EscapeCharacter { get; set; }
    }
}
