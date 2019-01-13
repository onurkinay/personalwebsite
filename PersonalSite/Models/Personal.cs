using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PersonalSite.Models
{
    public class Personal
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string image_desc { get; set; }
        public string desc { get; set; }
        public string skills { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string place { get; set; }
        public string map { get; set; }

    }
}
