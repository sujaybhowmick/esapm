using System;
using System.Collections.Generic;

namespace esapm.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime? CreateAt { get; set; }
    }
}
