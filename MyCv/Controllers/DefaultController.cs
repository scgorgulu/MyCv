using Microsoft.AspNetCore.Mvc;

namespace MyCv.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
