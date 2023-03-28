using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManager.Models
{
    public class PhoneNumber
    {
        public int Id { get; set; }
        public string NumberAsString { get; set; }
        public int ContactId { get; set; }
    }
}