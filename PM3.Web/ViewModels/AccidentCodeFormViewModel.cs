using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PM3.Web.ViewModels
{
    public class AccidentCodeFormViewModel
    {
        public HttpPostedFileBase File { get; set; }
        public string AccidentCodeTitle { get; set; }
        public string AccidentCodeDescription { get; set; }
    }
}