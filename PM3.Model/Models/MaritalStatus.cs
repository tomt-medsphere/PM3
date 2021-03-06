﻿using System.Collections.Generic;

namespace PM3.Model.Models
{
    public class MaritalStatus
    {
        public string MaritalStatusId { get; set; }
        public string Description { get; set; }

        // children
        public virtual List<Person> Persons { get; set; }
    }
}
