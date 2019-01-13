using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PersonalSite.Models;

namespace PersonalSite.Models
{
    public class PersonalSiteContext : DbContext
    {
        public PersonalSiteContext (DbContextOptions<PersonalSiteContext> options)
            : base(options)
        {
        }

        public DbSet<PersonalSite.Models.Personal> Personal { get; set; }

        public DbSet<PersonalSite.Models.Jobs> Jobs { get; set; }
    }
}
