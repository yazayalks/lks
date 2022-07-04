using Microsoft.AspNetCore.Mvc;

namespace lks.Controllers
{
    public class ContactsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}