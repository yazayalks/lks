using Microsoft.AspNetCore.Mvc;

namespace lks.Controllers
{
    public class ChatController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}