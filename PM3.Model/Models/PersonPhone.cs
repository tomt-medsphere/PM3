﻿namespace PM3.Model.Models
{
    public class PersonPhone
    {
        public int PersonPhoneId { get; set; }
        public int PersonId { get; set; }
        public int PhoneId { get; set; }
        public int Sequence { get; set; }
        public string Note { get; set; }
    }
}
