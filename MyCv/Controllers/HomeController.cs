using Microsoft.AspNetCore.Mvc;

namespace MyCv.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
