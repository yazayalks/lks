using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using lks.DbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using lks.Models;
using Microsoft.AspNetCore.Authorization;

namespace lks.Controllers
{
    public class HomeController : Controller
    {
        private lksContext lksContext;
        public HomeController(lksContext lksContext)
        {
            this.lksContext = lksContext;
        }

       // [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}