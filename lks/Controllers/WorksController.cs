using Microsoft.AspNetCore.Mvc;

namespace lks.Controllers
{
    public class WorksController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}