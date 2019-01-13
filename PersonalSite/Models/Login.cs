using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PersonalSite.Models
{
    public class Login
    {
        public string EMail { get; set; }
        public string Password { get; set; }
    }
}
