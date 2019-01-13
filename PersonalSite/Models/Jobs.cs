using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PersonalSite.Models
{
    public class Jobs
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public int status { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime end { get; set; }
    }
}
