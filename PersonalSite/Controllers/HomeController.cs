using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalSite.Models;

using System.Text.Encodings.Web;
using Microsoft.EntityFrameworkCore;

namespace PersonalSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly PersonalSiteContext _context;
        public HomeController(PersonalSiteContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            Info info = new Info();

            var personal = await _context.Personal
                .FirstOrDefaultAsync();
            if (personal == null)
            {
                return NotFound();
            }

            List<Jobs> jobs = _context.Jobs.ToList();
            personal.image = "/img/"+personal.image;
            info.person = personal;
            info.jobs = jobs;
            return View(info);
        }
          

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
