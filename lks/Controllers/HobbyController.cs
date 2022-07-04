using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace lks.Controllers
{
    public class HobbyController : Controller
    {
        // GET
         [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}