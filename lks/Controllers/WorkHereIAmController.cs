using System.Collections.Generic;
using System.Linq;
using lks.DbContexts;
using lks.Models;
using lks.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lks.Controllers
{
    public class WorkHereIAmController : Controller
    {
        private lksContext lksContext;

        public WorkHereIAmController(lksContext lksContext)
        {
            this.lksContext = lksContext;
            DbHelper.dbContext = this.lksContext;
        }

        // GET
        public IActionResult Index()
        {
            return View(CommentsLoader.Load<WorkHereIAmController>(lksContext));
        }
    }
}